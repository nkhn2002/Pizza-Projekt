using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Pizza_Projekt.Content.Menu
{
    public partial class Menu : System.Web.UI.Page
    {
        DAL Dal = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow row;

                dt.Columns.Add("PizzaID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Price");
                for (int i = 0; i < Dal.GetAllPizza().Count; i++)
                {
                    row = dt.NewRow();
                    row["PizzaID"] = Dal.GetAllPizza()[i].PizzaID;
                    row["Name"] = Dal.GetAllPizza()[i].Name;
                    row["Price"] = Dal.GetAllPizza()[i].Price;
                    dt.Rows.Add(row);

                }
                MenuGrid.DataSource = dt;
                MenuGrid.DataBind();
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            // Pizza list
            List<Pizza> list;

            int pizzaid = int.Parse(MenuGrid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[0].Text);
            string name = MenuGrid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[1].Text;
            float price = float.Parse(MenuGrid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[2].Text);

            if (Session["cart"] == null)
            {
                list = new List<Pizza>();
                list.Add(new Pizza(pizzaid, name, price));
                Session["cart"] = list;
            }
            else
            {
                list = (List<Pizza>)Session["cart"];
                list.Add(new Pizza(pizzaid, name, price));
                Session["cart"] = list;
            }
        }
    }
}