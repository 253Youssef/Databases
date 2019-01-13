using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Parent_SchoolsAcceptedMyChild : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd1 = new SqlCommand("ViewSchoolsAcceptedMyChild");
                string username1 = (string)(Session["username"]);
                string password1 = (string)(Session["password"]);
                cmd1.Parameters.Add(new SqlParameter("@usernameexist", username1));
                cmd1.Parameters.Add(new SqlParameter("@passexist", password1));
                cmd1.CommandType = CommandType.StoredProcedure;
                using (cmd1)
                {
                    cmd1.Connection = con;
                    con.Open();
                    DropDownList1.DataSource = cmd1.ExecuteReader();
                    DropDownList1.DataTextField = "name";
                    DropDownList1.DataValueField = "name";
                    DropDownList1.DataBind();
                    con.Close();
                }
            }
            DropDownList1.Items.Insert(0, new ListItem("--Select School--", "0"));
        }
    }

   
   

   

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string sname = DropDownList1.SelectedValue;
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("ParentChooseSchool", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        string username = (string)(Session["username"]);
        string password = (string)(Session["password"]);
        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", password));
        cmd.Parameters.Add(new SqlParameter("@s_name", sname));
        cmd.ExecuteNonQuery();
    }

   
}