using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza_Projekt
{
    public class SessionData
    {
        private int userid;
        private string username;
        private string password;
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

        public SessionData(int _id, string _user, string _pass, int _admin, int _employee)
        {
            userid = _id;
            username = _user;
            password = _pass;
            isadmin = _admin;
            isemployee = _employee;
        }
    }
}