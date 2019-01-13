using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_PostAnnouncements : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.AdminPostAnnouncements", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        string tdate = date.Text;
        string pdescription = description.Text;
        string ptitle = title.Text;
        string ptype = type.Text;



        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd.Parameters.Add(new SqlParameter("@an_date", DateTime.Parse(tdate)));
        cmd.Parameters.Add(new SqlParameter("@ann_description", pdescription));
        cmd.Parameters.Add(new SqlParameter("@title", ptitle));
        cmd.Parameters.Add(new SqlParameter("@acc_type", ptype));

        cmd.ExecuteNonQuery();

        Response.Redirect("/Admin/Home");

    }
}