using Microsoft.AspNet.Identity;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI;
using WebSite1;

public partial class Teacher : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.TeacherViewCourses", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        string un = Session["username"].ToString();
        string ps = Session["password"].ToString();

        
        //pass parameters to the stored procedure
        cmd.Parameters.Add(new SqlParameter("@usernameexist", un));
        cmd.Parameters.Add(new SqlParameter("@passexist", ps));

        conn.Open();

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

    /* protected void CreateUser_Click(object sender, EventArgs e)
     {
         //Get the information of the connection to the database
         string connStr = ConfigurationManager.ConnectionStrings["MyDBConn"].ToString();

         //create a new connection
         SqlConnection conn = new SqlConnection(connStr);

         /*create a new SQL command which takes as parameters the name of the stored procedure and
          the SQLconnection name*/

    /* SqlCommand cmd = new SqlCommand("dbo.TeacherViewCourses", conn);
     cmd.CommandType = CommandType.StoredProcedure;

     //To read the input from the user

     string un = Session["username"].ToString();
     string ps = Session["pass"].ToString();

     //pass parameters to the stored procedure
     cmd.Parameters.Add(new SqlParameter("@usernameexist", un));
     cmd.Parameters.Add(new SqlParameter("@passexist", ps));


     SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

     //Executing the SQLCommand
     conn.Open();
     cmd.ExecuteNonQuery();
     conn.Close();


     while (rdr.Read())
     {

     }
 }
 */

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Teacher/Home");
    }
}