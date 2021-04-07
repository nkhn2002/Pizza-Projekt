using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza_Projekt
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            DAL Dal = new DAL();

            switch (Dal.RegisterAccount(new UserManager(TB_Username.Text, TB_Password.Text)))
            {
                case "Successfully registered":
                    AlertBox.CssClass = "alert alert-success";
                    AlertBox.Text = "Successfully registered";
                    break;

                case "Error occured":
                    AlertBox.CssClass = "alert alert-warning";
                    AlertBox.Text = "Error occured";
                    break;

                case "Account already exists":
                    AlertBox.CssClass = "alert alert-warning";
                    AlertBox.Text = "Account already exists";
                    break;

                case "Wrong username format":
                    AlertBox.CssClass = "alert alert-warning";
                    AlertBox.Text = "Wrong username format";
                    break;

                case "Wrong password format":
                    AlertBox.CssClass = "alert alert-warning";
                    AlertBox.Text = "Wrong password format";
                    break;
            }
        }
    }
}