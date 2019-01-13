using Microsoft.AspNet.Identity;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI;
using WebSite1;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        //Get the information of the connection to the database
        string connStr = ConfigurationManager.ConnectionStrings["MyDBConn"].ToString();

        //create a new connection
        SqlConnection conn = new SqlConnection(connStr);

        /*create a new SQL command which takes as parameters the name of the stored procedure and
         the SQLconnection name*/
        SqlCommand cmd = new SqlCommand("dbo.ApplyForChildInSchool", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        //To read the input from the user
        string name = cname.Text;
        DateTime birthdate = DateTime.Parse(cbirth.Text);
        string gender = cgender.Text;
        string scname = sname.Text;
        string pun = parentusername.Text;
        string ppass = parentpassword.Text;

        //pass parameters to the stored procedure
        cmd.Parameters.Add(new SqlParameter("@name", name));
        cmd.Parameters.Add(new SqlParameter("@birthdate", birthdate));
        cmd.Parameters.Add(new SqlParameter("@gender", gender));
        cmd.Parameters.Add(new SqlParameter("@sname", scname));
        cmd.Parameters.Add(new SqlParameter("@usernameexist", pun));
        cmd.Parameters.Add(new SqlParameter("@passexist", ppass));


        //Executing the SQLCommand
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


        //To navigate to another webpage
        Response.Redirect("/Defaults.aspx", true);

    }
}