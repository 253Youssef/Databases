using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WriteReport : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.TeacherWritesReport", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string un = Session["username"].ToString();
        string ps = Session["password"].ToString();
        DateTime postdate = DateTime.ParseExact(dateinput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        string com = comment.Text;
        string stusn = stun.Text;


        cmd.Parameters.Add(new SqlParameter("@usernameexist", un));
        cmd.Parameters.Add(new SqlParameter("@passexist", ps));
        cmd.Parameters.Add(new SqlParameter("@issuedate", postdate));
        cmd.Parameters.Add(new SqlParameter("@teachercomment", com));
        cmd.Parameters.Add(new SqlParameter("@studentusername", stusn));


        cmd.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("/Teacher/4/WriteReport");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }
}