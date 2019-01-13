using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guest_ViewSchools : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.SchoolSearchCategoriseLevelAS", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        //IF the output is a table, then we can read the records one at a time
        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (rdr.Read())
        {
            //Get the value of the attribute name in the Schools table
            string SchoolsName = rdr.GetString(rdr.GetOrdinal("Schools"));

            //Get the value of the attribute field in the Company table
            //  string Level = rdr.GetString(rdr.GetOrdinal("name"));

            //Create a new label and add it to the HTML form
             Label Schools = new Label();
             Schools.Text = "School Name And Type: " + SchoolsName + "</br><hr>";
             PlaceHolder1.Controls.Add(Schools);
      


            /* Label lbl_CompanyField = new Label();
             lbl_CompanyField.Text = Level;
             FormView1.Controls.Add(lbl_CompanyField);
             */
        }
    }
}