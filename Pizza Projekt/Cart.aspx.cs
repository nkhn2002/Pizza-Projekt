using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Pizza_Projekt
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                CheckoutCart.Visible = false;
                CartHeaderLabel.Text = "You have nothing in cart!";
            }
            else
            {
                CheckoutCart.Visible = true;
                CartHeaderLabel.Text = "Cart";

                if (!Page.IsPostBack)
                {
                    DataTable dt = new DataTable();
                    DataRow row;
                    List<Pizza> list = (List<Pizza>)Session["Cart"];

                    dt.Columns.Add("Name");
                    dt.Columns.Add("Toppings");
                    dt.Columns.Add("Price");

                    for (int i = 0; i < list.Count; i++)
                    {
                        row = dt.NewRow();
                        row["Name"] = list[i].Name;
                        row["Toppings"] = list[i].Toppings;
                        row["Price"] = list[i].Price;
                        dt.Rows.Add(row);

                    }
                    MenuGrid.DataSource = dt;
                    MenuGrid.DataBind();
                }
            }
        }

        public int calcQuanity()
        {
            return 0;
        }
    }
}