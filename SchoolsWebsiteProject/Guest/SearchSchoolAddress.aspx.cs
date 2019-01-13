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

    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.SchoolSearchByAddress", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string input = adinput.Text;

        cmd.Parameters.Add(new SqlParameter("@address", input));

        //IF the output is a table, then we can read the records one at a time
        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        while (rdr.Read())
        {
            //Get the value of the attribute name in the Schools table
            string name = rdr.GetString(rdr.GetOrdinal("name"));
            string address_home = rdr.GetString(rdr.GetOrdinal("address_home"));
            int phone_num = rdr.GetInt32(rdr.GetOrdinal("phone_num"));
            string email = rdr.GetString(rdr.GetOrdinal("email"));
            string gen_information = rdr.GetString(rdr.GetOrdinal("gen_information"));
            string vision = rdr.GetString(rdr.GetOrdinal("vision"));
            string mission = rdr.GetString(rdr.GetOrdinal("mission"));
            string main_language = rdr.GetString(rdr.GetOrdinal("main_language"));
            string s_type = rdr.GetString(rdr.GetOrdinal("s_type"));
            int fees = rdr.GetInt32(rdr.GetOrdinal("fees"));
            int begingrade = rdr.GetInt32(rdr.GetOrdinal("begin_grade"));
            int endgrade = rdr.GetInt32(rdr.GetOrdinal("end_grade"));

            //Create a new label and add it to the HTML form


            Label scname = new Label();
            scname.Text = "School Name: " + name + "</br>";
            PlaceHolder1.Controls.Add(scname);

            Label addresshome = new Label();
            addresshome.Text = "Address: " + address_home + "</br>";
            PlaceHolder1.Controls.Add(addresshome);

            Label pnum = new Label();
            pnum.Text = "Phone Number: " + phone_num.ToString() + "</br>";
            PlaceHolder1.Controls.Add(pnum);

            Label em = new Label();
            em.Text = "Email: " + email + "</br>";
            PlaceHolder1.Controls.Add(em);

            Label gnin = new Label();
            gnin.Text = "General Info: " + gen_information + "</br>";
            PlaceHolder1.Controls.Add(gnin);

            Label vis = new Label();
            vis.Text = "Vision: " + vision + "</br>";
            PlaceHolder1.Controls.Add(vis);

            Label mis = new Label();
            mis.Text = "Mission: " + mission + "</br>";
            PlaceHolder1.Controls.Add(mis);

            Label ml = new Label();
            ml.Text = "Main Language: " + main_language + "</br>";
            PlaceHolder1.Controls.Add(ml);

            Label st = new Label();
            st.Text = "School Type: " + s_type + "</br>";
            PlaceHolder1.Controls.Add(st);

            Label fes = new Label();
            fes.Text = "Fees: " + fees.ToString() + "</br>";
            PlaceHolder1.Controls.Add(fes);

            Label bg = new Label();
            bg.Text = "Begin Grade: " + begingrade.ToString() + "</br>";
            PlaceHolder1.Controls.Add(bg);

            Label eg = new Label();
            eg.Text = "End Grade: " + endgrade.ToString() + "</br>" + "<hr>";
            PlaceHolder1.Controls.Add(eg);

        }
    }
}