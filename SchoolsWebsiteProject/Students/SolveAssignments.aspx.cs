using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students_SolveAssignments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("StudentViewAssignments");
                string username = (string)(Session["username"]);
                string password = (string)(Session["password"]);
                string code = (string)(Session["ccode"]);
                cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
                cmd.Parameters.Add(new SqlParameter("@passexist", password));
                cmd.Parameters.Add(new SqlParameter("@code", code));
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd)
                {
                    cmd.Connection = con;
                    con.Open();
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "content";
                    DropDownList1.DataValueField = "ass_id";
                    DropDownList1.DataBind();
                    con.Close();
                }
            }
            DropDownList1.Items.Insert(0, new ListItem("--Select Assignment--", "0"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string ass_id = DropDownList1.SelectedValue;
        string content = contentT.Text;

        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("StudentSolveAssignments", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        string username = (string)(Session["username"]);
        string password = (string)(Session["password"]);
        cmd.Parameters.Add(new SqlParameter("@usernameexist", username));
        cmd.Parameters.Add(new SqlParameter("@passexist", password));
        cmd.Parameters.Add(new SqlParameter("@a_id", ass_id));
        cmd.Parameters.Add(new SqlParameter("@solution", content));

        SqlDataReader rdr1 = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        Response.Redirect("/Students/ViewAssignments");
    }
}