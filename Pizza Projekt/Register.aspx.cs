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
        DAL dal = new DAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            string a = dal.RegísterAccount(TB_Username.Text, TB_Password.Text);

            switch (a)
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
            }
        }
    }
}