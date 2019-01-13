using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parent_RateTeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("ParentViewAllTeachers", conn);
        string username = (string)(Session["username"]);
        string password = (string)(Session["password"]);
        string stusername = (string)(Session["Student"]);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", password));
        cmd.Parameters.Add(new SqlParameter("@st_username", stusername));

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
        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd1 = new SqlCommand("ParentViewAllTeachers");
                string username1 = (string)(Session["username"]);
                string password1 = (string)(Session["password"]);


                cmd1.Parameters.Add(new SqlParameter("@usernameexist", username1));
                cmd1.Parameters.Add(new SqlParameter("@passexist", password1));
                cmd1.Parameters.Add(new SqlParameter("@st_username", stusername));

                cmd1.CommandType = CommandType.StoredProcedure;
                using (cmd1)
                {
                    cmd1.Connection = con;
                    con.Open();
                    DropDownList1.DataSource = cmd1.ExecuteReader();
                    DropDownList1.DataTextField = "username";
                    DropDownList1.DataValueField = "ID";
                    DropDownList1.DataBind();
                    con.Close();
                }
            }
            DropDownList1.Items.Insert(0, new ListItem("--Choose Teacher--", "0"));
        }
       }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);



        SqlCommand cmd = new SqlCommand("ParentRateTeachers", conn);
        cmd.CommandType = CommandType.StoredProcedure;



        conn.Open();
        string username = (string)(Session["username"]);
        string pass = (string)(Session["password"]);
        string I1D = DropDownList1.SelectedValue;
        int ID = Convert.ToInt32(I1D);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", pass));
        cmd.Parameters.Add(new SqlParameter("@rating", TextBox1.Text));
        cmd.Parameters.Add(new SqlParameter("@ID", ID));


        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        conn.Close();
        Response.Redirect("/Parent/ViewTeachersAndRateThem");
    }

    
}