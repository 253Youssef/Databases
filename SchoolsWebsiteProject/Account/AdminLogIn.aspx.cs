using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using WebSite1;

public partial class Account_Login : Page
{
    // The page_load method is called before loading the corresponding HTML file to the browser
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LogIn(object sender, EventArgs e)
    {
        //Get the information of the connection to the database
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

        //create a new connection
        SqlConnection conn = new SqlConnection(connStr);

        /*create a new SQL command which takes as parameters the name of the stored procedure and
         the SQLconnection name*/
        SqlCommand cmd = new SqlCommand("select dbo.AdminOrNot(@username, @pass)", conn);
        cmd.CommandType = CommandType.Text;


        //To read the input from the user
        string username = UserName.Text;
        string password = Password.Text;

        //pass parameters to the stored procedure
        cmd.Parameters.Add(new SqlParameter("@username", username));
        cmd.Parameters.Add(new SqlParameter("@pass", password));

        //Executing the SQLCommand
        conn.Open();
        cmd.ExecuteNonQuery();
        int res = (int)(cmd.ExecuteScalar());
        conn.Close();

        if (res.Equals(1))
        {
            Session["username"] = username;
            Session["password"] = password;
            Response.Redirect("/Admin/Home");

        }
    }
}