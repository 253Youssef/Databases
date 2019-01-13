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
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);


        SqlCommand cmd = new SqlCommand("dbo.TeacherViewAssignments", conn);
        cmd.CommandType = CommandType.StoredProcedure;



        conn.Open();

        string x = Session["username"].ToString();
        string y = Session["password"].ToString();

        cmd.Parameters.Add(new SqlParameter("@username", x));




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

        string x = Session["username"].ToString();
        string y = Session["password"].ToString();

        string connStr1 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn1 = new SqlConnection(connStr1);

        SqlCommand cmd1 = new SqlCommand("dbo.TeacherViewSolutions", conn1);
        cmd1.CommandType = CommandType.StoredProcedure;

        conn1.Open();


        string stun = suser.Text;
        int aid = Int32.Parse(assid.Text);
        string cc = ccode.Text;

        cmd1.Parameters.Add(new SqlParameter("@usernameexist", x));
        cmd1.Parameters.Add(new SqlParameter("@passexist", y));
        cmd1.Parameters.Add(new SqlParameter("@st_username", stun));
        cmd1.Parameters.Add(new SqlParameter("@ass_id", aid));
        cmd1.Parameters.Add(new SqlParameter("@c_code", cc));

        SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

        while (rdr1.Read())
        {
            Label ttl = new Label();
            ttl.Text = "Solution: " + "<hr>";
            PlaceHolder3.Controls.Add(ttl);

            string sol = rdr1.GetString(rdr1.GetOrdinal("solution"));
            Label solu = new Label();
            solu.Text = sol + "<br>";
            PlaceHolder3.Controls.Add(solu);
        }

    }

    public void gopg(object sender, System.EventArgs e)
    {
        Session["stusnm"] = suser.Text;
        Session["asid"] = Int32.Parse(assid.Text);
        Session["cc"] = ccode.Text;

        Response.Redirect("/Teacher/3/PostGrade");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }
}
