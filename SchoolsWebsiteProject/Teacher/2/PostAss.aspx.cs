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

public partial class PostAss : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.TeacherPostAssignmentForCourses", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string un = Session["username"].ToString();
        string ps = Session["password"].ToString();
        DateTime postdate = DateTime.ParseExact(dateinput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime duDate = DateTime.ParseExact(dueinput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        string cont = contentinput.Text;
        string cd = codeinput.Text;


        cmd.Parameters.Add(new SqlParameter("@usernameexist", un));
        cmd.Parameters.Add(new SqlParameter("@passexist", ps));
        cmd.Parameters.Add(new SqlParameter("@postdate", postdate));
        cmd.Parameters.Add(new SqlParameter("@content", cont));
        cmd.Parameters.Add(new SqlParameter("@duedate", duDate));
        cmd.Parameters.Add(new SqlParameter("@code", cd));
        

        cmd.ExecuteNonQuery();
        conn.Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }
}