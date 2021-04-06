using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza_Projekt
{
    public partial class Login : System.Web.UI.Page
    {
        DAL dal = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (dal.ValidateLogin(TB_Username.Text, TB_Password.Text))
            {
                AlertBox.CssClass = "alert alert-success";
                AlertBox.Text = "Successfully logged in...";
            }
            else
            {
                AlertBox.CssClass = "alert alert-warning";
                AlertBox.Text = "Error, wrong password..";
            }
        }
    }
}