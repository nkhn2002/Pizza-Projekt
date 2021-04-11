using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza_Projekt
{
    public class UserManager
    {
        private int userid;
        private string username;
        private string password;
        private string fullname;
        private string address;
        private int phone;
        private string email;
        private int isadmin;
        private int isemployee;

        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }

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

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int IsAdmin
        {
            get { return isadmin; }
            set { isadmin = value; }
        }

        public int IsEmployee
        {
            get { return isemployee; }
            set { isemployee = value; }
        }

        // For login & register
        public UserManager(string _user, string _pass)
        {
            username = _user;
            password = _pass;
        }

        // For gathering information about users data
        public UserManager(string _fullname, string _address, string _email, int _phone)
        {
            fullname = _fullname;
            address = _address;
            phone = _phone;
            email = _email;
        }

        public UserManager()
        {

        }
    }
}