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
        public string Conn = "Data Source=173.212.212.111; Initial Catalog = ZBPizza; User ID = ZBPizza; Password=ABC1234!";

        // Validate login
        public bool ValidateLogin(UserManager UM)
        {
            try
            {
                string query = $"SELECT * FROM Users WHERE username = @Username AND password = @Password";
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Username", UM.Username);
                    cmd.Parameters.AddWithValue("@Password", UM.Password);

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

        // Validate email (Useless for now)
        public bool validateEmail(string email)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @Email";
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Email", email);
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
    }
}