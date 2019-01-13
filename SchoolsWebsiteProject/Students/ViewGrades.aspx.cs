using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students_ViewGrades : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("StudentViewCourses");
                string username = (string)(Session["username"]);
                string password = (string)(Session["password"]);
                cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
                cmd.Parameters.Add(new SqlParameter("@passexist", password));
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd)
                {
                    cmd.Connection = con;
                    con.Open();
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "CourseName";
                    DropDownList1.DataValueField = "Course Code";
                    DropDownList1.DataBind();
                    con.Close();
                }
            }
            DropDownList1.Items.Insert(0, new ListItem("--Select Course--", "0"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (this.IsPostBack)
        {
            string ccode = DropDownList1.SelectedValue;
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("StudentViewGrade", conn);
            string username = (string)(Session["username"]);
            string password = (string)(Session["password"]);
            cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
            cmd.Parameters.Add(new SqlParameter("@passexist", password));
            cmd.Parameters.Add(new SqlParameter("@code", ccode));
            cmd.CommandType = CommandType.StoredProcedure;
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
    }
}