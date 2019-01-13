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
        SqlCommand cmd = new SqlCommand("dbo.ParentSignUp", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        //To read the input from the user
        int pssn = int.Parse(ssn.Text);
        int mobilen = int.Parse(mobile.Text);
        int homen = int.Parse(Homephone.Text);
        string firstName = FirstName.Text;
        string middleName = MiddleName.Text;
        string lastName = LastName.Text;
        string paddress = address.Text;
        string Email = email.Text;
        string un = username.Text;
        string pass = password.Text;

        //pass parameters to the stored procedure
        cmd.Parameters.Add(new SqlParameter("@ssn", pssn));
        cmd.Parameters.Add(new SqlParameter("@fname", firstName));
        cmd.Parameters.Add(new SqlParameter("@mname", middleName));
        cmd.Parameters.Add(new SqlParameter("@lname", lastName));
        cmd.Parameters.Add(new SqlParameter("@address", paddress));
        cmd.Parameters.Add(new SqlParameter("@email", Email));
        cmd.Parameters.Add(new SqlParameter("@mobile", mobilen));
        cmd.Parameters.Add(new SqlParameter("@homephone", homen));
        cmd.Parameters.Add(new SqlParameter("@username", un));
        cmd.Parameters.Add(new SqlParameter("@pass", pass));


        //Executing the SQLCommand
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        //To navigate to another webpage
        Response.Redirect("/Default.aspx", true);

    }
}