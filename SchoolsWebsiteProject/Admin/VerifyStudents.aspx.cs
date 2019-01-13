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


        SqlCommand cmd = new SqlCommand("dbo.AdminViewEnrolledStudents", conn);
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
            int c_ssn = rdr.GetInt32(rdr.GetOrdinal("c_ssn"));
            id1 = c_ssn;
            string name = rdr.GetString(rdr.GetOrdinal("name"));
            string gender = rdr.GetString(rdr.GetOrdinal("gender"));
            int age = rdr.GetInt32(rdr.GetOrdinal("age"));
            int ssn = rdr.GetInt32(rdr.GetOrdinal("ssn"));


            //Create a new label and add it to the HTML form



            Label cssn = new Label();
            cssn.Text = "ChildSSN: " + c_ssn.ToString() + "</br>";
            PlaceHolder2.Controls.Add(cssn);

            Label cname = new Label();
            cname.Text = "Name: " + name + "</br>";
            PlaceHolder2.Controls.Add(cname);

            Label cgender = new Label();
            cgender.Text = "Gender: " + gender + "</br>";
            PlaceHolder2.Controls.Add(cgender);

            Label cage = new Label();
            cage.Text = "Age: " + age.ToString() + "</br>";
            PlaceHolder2.Controls.Add(cage);

            Label pssn = new Label();
            pssn.Text = "ParentSSN: " + ssn.ToString() + "</br>";
            PlaceHolder2.Controls.Add(pssn);

            Label br = new Label();
            br.Text = "</br>";

            Label hr = new Label();
            hr.Text = "<hr>";

            /* TextBox un = new TextBox();
             TextBox ps = new TextBox();

             Button verify = new Button();
             verify.Text = "Verify";
             verify.Click += new EventHandler(this.buttonClick);
             PlaceHolder2.Controls.Add(un);
             PlaceHolder2.Controls.Add(br);
             PlaceHolder2.Controls.Add(ps);
             PlaceHolder2.Controls.Add(br);
             PlaceHolder2.Controls.Add(verify);
             PlaceHolder2.Controls.Add(br);
             PlaceHolder2.Controls.Add(hr);
             */

        }
    }
    public void buttonClick(object sender, System.EventArgs e)
    {

        string un = username.Text;
        string pass = password.Text;

        string connStr1 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn1 = new SqlConnection(connStr1);

        SqlCommand cmd1 = new SqlCommand("dbo.AdminVerifyStudents", conn1);
        cmd1.CommandType = CommandType.StoredProcedure;

        conn1.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);


        cmd1.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd1.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd1.Parameters.Add(new SqlParameter("@cssn", id1));
        cmd1.Parameters.Add(new SqlParameter("@username", un));
        cmd1.Parameters.Add(new SqlParameter("@pass", pass));

        

        Response.Redirect("/Admin/VerifyStudents");
    }
}
