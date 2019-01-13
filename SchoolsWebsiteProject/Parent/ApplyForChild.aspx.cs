using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parent_ApplyForChild : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {



        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);



        SqlCommand cmd = new SqlCommand("ApplyForChildInSchool", conn);
        cmd.CommandType = CommandType.StoredProcedure;



        conn.Open();
        string username = (string)(Session["username"]);
        string pass = (string)(Session["password"]);


        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", pass));
        cmd.Parameters.Add(new SqlParameter("@c_ssn", TextBox1.Text));
        cmd.Parameters.Add(new SqlParameter("@name", TextBox2.Text));
        cmd.Parameters.Add(new SqlParameter("@birthdate", TextBox3.Text));
        cmd.Parameters.Add(new SqlParameter("@gender", TextBox4.Text));
        cmd.Parameters.Add(new SqlParameter("@sname", TextBox5.Text));


        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        conn.Close();
        Response.Redirect("/Parent/ApplyForChild");
    }
}