using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Pizza_Projekt
{
    public partial class Login : System.Web.UI.Page
    {
        List<Pizza> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            list = (List<Pizza>)Session["cart"];

            for (int i = 0; i < list.Count; i++) 
            {
                Debug.WriteLine(list[i].Name);
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            DAL Dal = new DAL();

            if (Dal.ValidateLogin(new UserManager(TB_Username.Text, TB_Password.Text)))
            {
                SessionData data = Dal.getSessionData(1); // Get User Data

                // Set user data to session
                Session["userid"] = data.UserID.ToString();
                Session["username"] = data.Username;
                Session["password"] = data.Password;
                Session["admin"] = data.IsAdmin.ToString();
                Session["employee"] = data.IsEmployee.ToString();

                Response.Redirect("/Profile/UserInfo.aspx");
            }
            else
            {
                AlertBox.CssClass = "alert alert-warning";
                AlertBox.Text = "Error, wrong password..";
            }
        }
    }
}