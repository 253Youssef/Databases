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

public partial class ViewQues : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public void buttonClick(object sender, System.EventArgs e)
    {

        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);


        SqlCommand cmd = new SqlCommand("dbo.TeacherViewQuestions", conn);
        cmd.CommandType = CommandType.StoredProcedure;



        conn.Open();

        string x = Session["username"].ToString();
        string y = Session["password"].ToString();
        string c = ccode.Text;

        cmd.Parameters.Add(new SqlParameter("@usernameexist", x));
        cmd.Parameters.Add(new SqlParameter("@passexist", y));
        cmd.Parameters.Add(new SqlParameter("@code", c));




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

    public void goan(object sender, System.EventArgs e)
    {
        string x = Session["username"].ToString();
        string y = Session["password"].ToString();
        Session["qid"] = Int32.Parse(qid.Text); 
        Response.Redirect("/Teacher/5/AnswerQuestion");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }
}
