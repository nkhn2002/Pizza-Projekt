using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Pizza_Projekt
{
    public class DAL
    {
        public string Conn = "Data Source=173.212.212.111; Initial Catalog = ZBPizza; User ID = ZBPizza; Password=ABC1234!";

        // Validate login
        public bool ValidateLogin(string user, string pass)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM Users WHERE username = @Username AND password = @Password";
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Username", user);
                    cmd.Parameters.AddWithValue("@Password", pass);

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
            catch(Exception ex)
            {
                return false;
            }
        }

        // Validate username when registering
        public bool validateUsername(string user)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username";
                using(SqlConnection connection = new SqlConnection(Conn))
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
        public string RegísterAccount(string user, string pass)
        {
            try
            {
                if(validateUsername(user))
                {
                    return "Account already exists";
                }

                string query = "INSERT INTO Users (Username, Password, IsAdmin, IsEmployee) VALUES (@Username, @Password, 0, 0)";
                using(SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Username", user);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                    if (i > 0)
                    {
                        return "Successfully registered";
                    }
                    else
                    {
                        return "Error occured ";
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}