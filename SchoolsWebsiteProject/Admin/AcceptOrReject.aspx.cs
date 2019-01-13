using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AcceptOrReject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void buttonClick(object sender, System.EventArgs e)
    {
        string pssn = ssn.Text;

        string c_ssn = cssn.Text;

        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);


        conn.Open();

        SqlCommand cmd = new SqlCommand("dbo.AdminAcceptOrReject", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]); 

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd.Parameters.Add(new SqlParameter("@parentssn", pssn));
        cmd.Parameters.Add(new SqlParameter("@cssn", c_ssn));
        cmd.Parameters.Add(new SqlParameter("@status", 1));


        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        Response.Redirect("/Admin/AcceptOrReject");

    }
    public void buttonClick2(object sender, System.EventArgs e)
    {
        string pssn = ssn.Text;

        string c_ssn = cssn.Text;

        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        conn.Open();

        SqlCommand cmd = new SqlCommand("dbo.AdminAcceptOrReject", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd.Parameters.Add(new SqlParameter("@parentssn", pssn));
        cmd.Parameters.Add(new SqlParameter("@cssn", c_ssn));
        cmd.Parameters.Add(new SqlParameter("@status", 0));


        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);


        Response.Redirect("/Admin/AcceptOrReject");
    }
}