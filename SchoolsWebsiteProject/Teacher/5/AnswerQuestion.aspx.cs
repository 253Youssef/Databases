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

        SqlCommand cmd2 = new SqlCommand("dbo.TeacherAnswerQuestions", conn2);
        cmd2.CommandType = CommandType.StoredProcedure;

        conn2.Open();

        string x = Session["username"].ToString();
        string y = Session["password"].ToString();
        int quid = Int32.Parse(Session["qid"].ToString());
        string ans = answer.Text;

        cmd2.Parameters.Add(new SqlParameter("@usernameexist", x));
        cmd2.Parameters.Add(new SqlParameter("@passexist", y));
        cmd2.Parameters.Add(new SqlParameter("@q_id", quid));
        cmd2.Parameters.Add(new SqlParameter("@answer", ans));
        cmd2.ExecuteNonQuery();
        conn2.Close();

        Response.Redirect("/Teacher/5/ViewQuestions");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }

}
