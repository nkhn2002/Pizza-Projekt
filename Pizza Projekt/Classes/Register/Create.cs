using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza_Projekt
{
    public class Create
    {
        private string username;
        private string email;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Create(string _username, string _email, string _password)
        {
            Username = _username;
            Email = _email;
            Password = _password;
        }

        public Create()
        {

        }

        public void CreateAccount(Create create)
        {

        }
    }
}