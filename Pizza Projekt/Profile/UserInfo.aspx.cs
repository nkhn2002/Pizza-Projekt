using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza_Projekt.Profile
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"].ToString().Length > 0)
            {
                DAL Dal = new DAL();

                UserManager user = Dal.getUserData(int.Parse(Session["UserID"].ToString()));

                Name.Text = user.Fullname;
                Address.Text = user.Address;
                Phone.Text = user.Phone.ToString();
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }
    }
}