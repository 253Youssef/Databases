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
        SqlCommand cmd = new SqlCommand("dbo.signUp", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        //To read the input from the user
        string firstName = FirstName.Text;
        string middleName = MiddleName.Text;
        string lastName = LastName.Text;
        DateTime birthdate = DateTime.Parse(Birthdate.Text);
        string address = Address.Text;
        string email = Email.Text;
        string gender = Gender.Text;
        string sname = sName.Text;
        int x = 0;

        //pass parameters to the stored procedure
        cmd.Parameters.Add(new SqlParameter("@firstname", firstName));
        cmd.Parameters.Add(new SqlParameter("@middlename", middleName));
        cmd.Parameters.Add(new SqlParameter("@lastname", lastName));
        cmd.Parameters.Add(new SqlParameter("@birthdate", birthdate));
        cmd.Parameters.Add(new SqlParameter("@taddress", address));
        cmd.Parameters.Add(new SqlParameter("@email", email));
        cmd.Parameters.Add(new SqlParameter("@gender", gender));
        cmd.Parameters.Add(new SqlParameter("@years_of_experience", x));
        cmd.Parameters.Add(new SqlParameter("@s_name", sname));


        //Executing the SQLCommand
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("/Default.aspx");

    }
}