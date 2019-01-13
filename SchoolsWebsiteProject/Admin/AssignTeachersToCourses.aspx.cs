using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AssignTeachersToCourses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("AdminGetTeachers");
                string username = (string)(Session["username"]);
                string password = (string)(Session["password"]);
                cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
                cmd.Parameters.Add(new SqlParameter("@passexist", password));
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd)
                {
                    cmd.Connection = con;
                    con.Open();
                    Teachers.DataSource = cmd.ExecuteReader();
                    Teachers.DataTextField = "ID";
                    Teachers.DataValueField = "ID";
                    Teachers.DataBind();
                    con.Close();
                }
            }
            Teachers.Items.Insert(0, new ListItem("--Select TeacherID--", "0"));
        }

        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd1 = new SqlCommand("AdminGetCourses");
                string username = (string)(Session["username"]);
                string password = (string)(Session["password"]);
                cmd1.Parameters.Add(new SqlParameter("@usernameexist", username));
                cmd1.Parameters.Add(new SqlParameter("@passexist", password));
                cmd1.CommandType = CommandType.StoredProcedure;
                using (cmd1)
                {
                    cmd1.Connection = con;
                    con.Open();
                    Courses.DataSource = cmd1.ExecuteReader();
                    Courses.DataTextField = "code";
                    Courses.DataValueField = "code";
                    Courses.DataBind();
                    con.Close();
                }
            }
            Courses.Items.Insert(0, new ListItem("--Select CourseID--", "0"));
        }
    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.AdminAssignTeacherToCourses", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        string tid2 = Teachers.SelectedValue;
        int tid = Convert.ToInt32(tid2);

        string cid2 = Courses.SelectedValue;
        int cid = Convert.ToInt32(cid2);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd.Parameters.Add(new SqlParameter("@code", cid));
        cmd.Parameters.Add(new SqlParameter("@ID", tid));

        cmd.ExecuteNonQuery();

        Response.Redirect("/Admin/AssignTeachersToCourses");
    }
}