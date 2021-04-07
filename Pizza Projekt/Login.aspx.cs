using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Threading;

namespace Pizza_Projekt
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            DAL Dal = new DAL();

            if (Dal.ValidateLogin(new UserManager(TB_Username.Text, TB_Password.Text)))
            {
                AlertBox.CssClass = "alert alert-success";
                AlertBox.Text = "Successfully logged in...";

                // Start status checker thread
                Task.Factory.StartNew(delegate ()
                {
                    Thread.Sleep(1500);
                    FormsAuthentication.RedirectFromLoginPage(TB_Username.Text, true);
                });
            }
            else
            {
                AlertBox.CssClass = "alert alert-warning";
                AlertBox.Text = "Error, wrong password..";
            }
        }
    }
}