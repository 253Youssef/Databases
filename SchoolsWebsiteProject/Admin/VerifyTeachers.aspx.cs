using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guest_ViewSchools : System.Web.UI.Page
{


    int id1;
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.AdminViewSignedUpTeachers", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));

        //IF the output is a table, then we can read the records one at a time
        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        
        while (rdr.Read())
        {
            //Get the value of the attribute name in the Schools table
            int id = rdr.GetInt32(rdr.GetOrdinal("ID"));
            id1 = id;
            string fname = rdr.GetString(rdr.GetOrdinal("f_name"));
            string mname = rdr.GetString(rdr.GetOrdinal("m_name"));
            string lname = rdr.GetString(rdr.GetOrdinal("l_name"));
            string eaddress = rdr.GetString(rdr.GetOrdinal("e_address"));
            string email = rdr.GetString(rdr.GetOrdinal("email"));
            string gender = rdr.GetString(rdr.GetOrdinal("gender"));


            //Create a new label and add it to the HTML form

            

            Label tid = new Label();
            tid.Text = "ID: " + id.ToString() + "</br>";
            PlaceHolder2.Controls.Add(tid);

            Label tfname = new Label();
            tfname.Text = "First Name: " +fname + "</br>";
            PlaceHolder2.Controls.Add(tfname);

            Label tmname = new Label();
            tmname.Text = "Middle Name: " + mname + "</br>";
            PlaceHolder2.Controls.Add(tmname);

            Label tlname = new Label();
            tlname.Text = "Last Name: " + lname + "</br>";
            PlaceHolder2.Controls.Add(tlname);

            Label taddress = new Label();
            taddress.Text = "Address: " + eaddress + "</br>";
            PlaceHolder2.Controls.Add(taddress);

            Label temail = new Label();
            temail.Text = "Email: " + email + "</br>";
            PlaceHolder2.Controls.Add(temail);

            Label tgender = new Label();
            tgender.Text = "Gender: " + gender + "</br>";
            PlaceHolder2.Controls.Add(tgender);

            Label br = new Label();
            br.Text = "</br>";

            Label hr = new Label();
            hr.Text = "<hr>";


        }
    }
    
    public void buttonClick(object sender, System.EventArgs e)
    {
        string un = username.Text;
        string pass = password.Text;

        string connStr1 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn1 = new SqlConnection(connStr1);

        SqlCommand cmd1 = new SqlCommand("dbo.AdminVerifySignedUpTeachers", conn1);
        cmd1.CommandType = CommandType.StoredProcedure;

        conn1.Open();


        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        cmd1.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd1.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd1.Parameters.Add(new SqlParameter("@ID", id1));
        cmd1.Parameters.Add(new SqlParameter("@username", un));
        cmd1.Parameters.Add(new SqlParameter("@pass", pass));

        SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

        Response.Redirect("/Admin/VerifyTeachers");
    }
}