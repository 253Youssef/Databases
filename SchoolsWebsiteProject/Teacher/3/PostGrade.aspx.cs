using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewAss : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public void buttonClick(object sender, EventArgs e)
    {
        string connStr2 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn2 = new SqlConnection(connStr2);

        SqlCommand cmd2 = new SqlCommand("dbo.TeacherGradeAssignment", conn2);
        cmd2.CommandType = CommandType.StoredProcedure;

        conn2.Open();

        string x = Session["username"].ToString();
        string y = Session["password"].ToString();
        string stun = Session["stusnm"].ToString();
        int aid = Int32.Parse(Session["asid"].ToString());
        string cc = Session["cc"].ToString();
        int gr = Int32.Parse(grade.Text);

        cmd2.Parameters.Add(new SqlParameter("@usernameexist", x));
        cmd2.Parameters.Add(new SqlParameter("@passexist", y));
        cmd2.Parameters.Add(new SqlParameter("@st_username", stun));
        cmd2.Parameters.Add(new SqlParameter("@ass_id", aid));
        cmd2.Parameters.Add(new SqlParameter("@c_code", cc));
        cmd2.Parameters.Add(new SqlParameter("@grade", gr));
        cmd2.ExecuteNonQuery();
        conn2.Close();

        Response.Redirect("/Teacher/3/ViewGradeAssig");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }
}
