using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Diagnostics;

namespace Pizza_Projekt
{
    public partial class Admin : System.Web.UI.Page
    {
        DAL Dal = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "1")
            {
                DataTable dt = new DataTable();
                DataRow row;

                dt.Columns.Add("ID");
                dt.Columns.Add("Username");
                dt.Columns.Add("Name");
                dt.Columns.Add("Address");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");
                for (int i = 0; i < Dal.GetAllUserData().Count; i++)
                {
                    row = dt.NewRow();
                    row["ID"] = Dal.GetAllUserData()[i].UserID;
                    row["Username"] = Dal.GetAllUserData()[i].Username;
                    row["Name"] = Dal.GetAllUserData()[i].Fullname;
                    row["Address"] = Dal.GetAllUserData()[i].Address;
                    row["Email"] = Dal.GetAllUserData()[i].Email;
                    row["Phone"] = Dal.GetAllUserData()[i].Phone;
                    dt.Rows.Add(row);

                }
                MenuGrid.DataSource = dt;
                MenuGrid.DataBind();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}