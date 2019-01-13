using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CreateAndAssign : System.Web.UI.Page
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

    }
    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.AdminCreateAndAssignActivities", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);
        string sdate = date.Text;
        DateTime atime = DateTime.Parse(sdate);
        string adescription = description.Text;
        string atype = type.Text;
        string alocation = location.Text;
        string aequipment = equipment.Text;
        string tid2 = Teachers.SelectedValue;
        int tid = Convert.ToInt32(tid2);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd.Parameters.Add(new SqlParameter("@ac_date", atime));
        cmd.Parameters.Add(new SqlParameter("@ac_description", adescription));
        cmd.Parameters.Add(new SqlParameter("@ac_type", atype));
        cmd.Parameters.Add(new SqlParameter("@ac_location", alocation));
        cmd.Parameters.Add(new SqlParameter("@equipment", aequipment));
        cmd.Parameters.Add(new SqlParameter("@t_ID", tid));

        cmd.ExecuteNonQuery();

        Response.Redirect("/Admin/CreateAndAssign");
    }
}