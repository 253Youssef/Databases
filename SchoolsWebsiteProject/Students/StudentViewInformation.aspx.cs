using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students_StudentViewInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("StudentViewOwnRecords", conn);
        string x = (string)(Session["username"]);
        cmd.Parameters.Add(new SqlParameter("@username", x));
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

    }

    public void buttonClick(object sender, System.EventArgs e)
    {


        string connStr1 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn1 = new SqlConnection(connStr1);

        SqlCommand cmd1 = new SqlCommand("dbo.StudentUpdateOwnRecords", conn1);
        cmd1.CommandType = CommandType.StoredProcedure;

        conn1.Open();

        string sessionuser = (string)(Session["username"]);
        string sessionpass = (string)(Session["password"]);
        string name = cname.Text;
        string pass = password.Text;
        DateTime birthdate = DateTime.Parse(Birthdate.Text);


        cmd1.Parameters.Add(new SqlParameter("@usernameexist", sessionuser));
        cmd1.Parameters.Add(new SqlParameter("@passexist", sessionpass));
        cmd1.Parameters.Add(new SqlParameter("@name", name));
        cmd1.Parameters.Add(new SqlParameter("@pass", pass));
        cmd1.Parameters.Add(new SqlParameter("@birthdate", birthdate));
        cmd1.Parameters.Add(new SqlParameter("@gender", TextBox1.Text));

        SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

        Response.Redirect("/Students/StudentViewInformation");
    }

 
}