using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza_Projekt
{
    public class UserManager
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserManager(string _user, string _pass)
        {
            username = _user;
            password = _pass;
        }

        public UserManager()
        {

        }
    }
}