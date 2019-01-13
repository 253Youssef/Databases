using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parent_ReviewSchool : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("ViewSchools", conn);
        string username = (string)(Session["username"]);
        string password = (string)(Session["password"]);
        string stusername = (string)(Session["Student"]);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", password));
        cmd.Parameters.Add(new SqlParameter("@st_username", stusername));

        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        adapter.SelectCommand = cmd;
        adapter.Fill(ds);
        adapter.Dispose();
        cmd.Dispose();
        conn.Close();

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd1 = new SqlCommand("ViewSchools");
                string username1 = (string)(Session["username"]);
                string password1 = (string)(Session["password"]);
                

                cmd1.Parameters.Add(new SqlParameter("@usernameexist", username1));
                cmd1.Parameters.Add(new SqlParameter("@passexist", password1));
                cmd1.Parameters.Add(new SqlParameter("@st_username", stusername));

                cmd1.CommandType = CommandType.StoredProcedure;
                using (cmd1)
                {
                    cmd1.Connection = con;
                    con.Open();
                    DropDownList2.DataSource = cmd1.ExecuteReader();
                    DropDownList2.DataTextField = "name";
                    DropDownList2.DataValueField = "name";
                    DropDownList2.DataBind();
                    con.Close();
                }
            }
            DropDownList2.Items.Insert(0, new ListItem("--Choose School--", "0"));
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);



        SqlCommand cmd = new SqlCommand("ParentWritesReviewAboutChildrenSchool", conn);
        cmd.CommandType = CommandType.StoredProcedure;



        conn.Open();
        string username = (string)(Session["username"]);
        string pass = (string)(Session["password"]);
        string sname = DropDownList2.SelectedValue;


        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", pass));
        cmd.Parameters.Add(new SqlParameter("@review", TextBox1.Text));
        cmd.Parameters.Add(new SqlParameter("@sname", sname));


        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        conn.Close();
        Response.Redirect("/Parent/ViewSchoolAndReviewIt");

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}