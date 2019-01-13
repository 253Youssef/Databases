using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parent_ViewSchoolAndReviewIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd1 = new SqlCommand("ParentViewStudents");
                string username1 = (string)(Session["username"]);
                string password1 = (string)(Session["password"]);
                string ID = (string)(Session["ID"]);
                string avgRating = (string)(Session["avgRating"]);


                cmd1.Parameters.Add(new SqlParameter("@usernameexist", username1));
                cmd1.Parameters.Add(new SqlParameter("@passexist", password1));

                cmd1.CommandType = CommandType.StoredProcedure;
                using (cmd1)
                {
                    cmd1.Connection = con;
                    con.Open();
                    DropDownList1.DataSource = cmd1.ExecuteReader();
                    DropDownList1.DataTextField = "username";
                    DropDownList1.DataValueField = "username";
                    DropDownList1.DataBind();
                    con.Close();
                }
            }
            DropDownList1.Items.Insert(0, new ListItem("--Choose Student--", "0"));

        }
        }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Student"] = DropDownList1.SelectedValue;
        Response.Redirect("/Parent/ReviewSchool.aspx");

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}