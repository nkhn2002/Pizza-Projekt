using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pizza_Projekt
{
    public class Login2
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

        public Login2(string _username, string _password)
        {
            username = _username;
            password = _password;

        }

        public Login2()
        {

        }
    }
}