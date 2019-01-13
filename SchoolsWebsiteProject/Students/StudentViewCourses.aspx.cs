using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students_StudentViewCourses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("StudentViewCourses", conn);
        string username = (string)(Session["username"]);
        string password = (string)(Session["password"]);
        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", password));
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
}