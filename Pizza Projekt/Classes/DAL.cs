using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Pizza_Projekt
{
    public class DAL
    {
        public string Conn = "Server=173.212.212.111;Database=ZBPizza;User Id=ZBPizza;Password=ABC1234!;";

        #region ValidateLogin
        // Validate login
        public bool ValidateLogin(UserManager UM)
        {
            try
            {
                string query = $"SELECT * FROM Users WHERE username = '{UM.Username}' AND password = '{UM.Password}'";
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    connection.Close();

                    string password = dt.Rows[0]["Password"].ToString();
                    int count = dt.Rows.Count;

                    if (UM.Password == password && count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        #endregion

        #region ValidateUsername
        // Validate username when registering
        public bool validateUsername(string user)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username";
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Username", user);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    connection.Close();

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region RegisterAccount

        // Register new account
        public string RegisterAccount(UserManager UM)
        {
            try
            {
                // Check username length
                if (UM.Username.Length < 6 || UM.Username.Length > 12)
                {
                    return "Wrong username format";
                }

                // Check password length
                if (UM.Password.Length < 8 || UM.Password.Length > 32)
                {
                    return "Wrong password format";
                }

                // Check if username already exists
                if (validateUsername(UM.Username))
                {
                    return "Account already exists";
                }

                // String query
                string query = "INSERT INTO Users (Username, Password, IsAdmin, IsEmployee) VALUES (@Username, @Password, 0, 0)";

                // New SQL Connection 
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Username", UM.Username);
                    cmd.Parameters.AddWithValue("@Password", UM.Password);

                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                    if (i > 0)
                    {
                        addInfoToUserData(UM.Username, UM.Password);
                        return "Successfully registered";
                    }
                    else
                    {
                        return "Error occured";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString()); // Debugging
                return ex.ToString();
            }
        }
        #endregion

        #region AddInfoToUserData
        public void addInfoToUserData(string _user, string _pass)
        {
            // String query
            string query = "INSERT INTO UserData(UserID, Fullname, Phone, Email, Address) VALUES (@UserID, '', 0, '' ,'')";

            // Get User ID
            int userID = getUserID(_user, _pass);
            Debug.WriteLine(userID);

            // New SQL Connection 
            using (SqlConnection connection = new SqlConnection(Conn))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@UserID", userID);

                int i = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region SessionData

        public SessionData getSessionData(int userID)
        {
            string query = $"SELECT * FROM Users WHERE UserID = {userID}";
            using (SqlConnection connection = new SqlConnection(Conn))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                int count = dt.Rows.Count;

                // Data
                int userid = int.Parse(dt.Rows[0]["UserID"].ToString());
                string user = dt.Rows[0]["Username"].ToString();
                string pass = dt.Rows[0]["Password"].ToString();
                int admin = int.Parse(dt.Rows[0]["IsAdmin"].ToString());
                int employee = int.Parse(dt.Rows[0]["IsEmployee"].ToString());

                if (count == 1)
                {
                    return new SessionData(userid, user, pass, admin, employee);
                }
                else
                {
                    return new SessionData(0, "", "", 0, 434);
                }
            }
        }
        #endregion

        #region getUserData
        public UserManager getUserData(int userID)
        {
            string query = $"SELECT * FROM UserData WHERE UserID = {userID}";
            using (SqlConnection connection = new SqlConnection(Conn))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                DataTable dt = new DataTable();
                SqlDataAdapter at = new SqlDataAdapter(query, connection);
                at.Fill(dt);

                int count = dt.Rows.Count;

                // Data
                int userid = int.Parse(dt.Rows[0]["UserID"].ToString());
                string fullname = dt.Rows[0]["Fullname"].ToString();
                string email = dt.Rows[0]["Email"].ToString();
                int phone = int.Parse(dt.Rows[0]["Phone"].ToString());
                string address = dt.Rows[0]["Address"].ToString();

                if (count == 1)
                {
                    return new UserManager(fullname, address, email, phone);
                }
                else
                {
                    return new UserManager("", "", "", 0);
                }
            }
        }
        #endregion

        #region GetUserID
        public int getUserID(string _user, string _pass)
        {
            string query = $"SELECT UserID FROM Users WHERE username = '{_user}' AND password = '{_pass}'";
            using (SqlConnection connection = new SqlConnection(Conn))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                int count = dt.Rows.Count;

                if (count == 1)
                {
                    return int.Parse(dt.Rows[0]["UserID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion

        #region GetAllPizza
        public List<Pizza> GetAllPizza()
        {
            List<Pizza> list = new List<Pizza>();

            string query = "SELECT * FROM Pizza";
            using(SqlConnection connection = new SqlConnection(Conn))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    list.Add(new Pizza(int.Parse(dt.Rows[i]["PizzaID"].ToString()), dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Toppings"].ToString(), float.Parse(dt.Rows[i]["Price"].ToString())));
                }
                return list;
            }
        }
        #endregion

        public List<UserManager> GetAllUserData()
        {
            List<UserManager> list = new List<UserManager>();
            string query = "SELECT * FROM Users JOIN UserData ON Users.UserID = UserData.UserID; ";
            using (SqlConnection connection = new SqlConnection(Conn))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    list.Add(new UserManager(int.Parse(dt.Rows[i]["UserID"].ToString()), dt.Rows[i]["Username"].ToString(), dt.Rows[i]["Fullname"].ToString(), dt.Rows[i]["Address"].ToString(), dt.Rows[i]["Email"].ToString(), int.Parse(dt.Rows[i]["Phone"].ToString())));
                }
                return list;
            }
        }
    }
}