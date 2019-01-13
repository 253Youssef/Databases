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
    int z = 0;
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        string connStr1 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn1 = new SqlConnection(connStr1);

        string connStr2 = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn2 = new SqlConnection(connStr2);

        SqlCommand cmd = new SqlCommand("dbo.SchoolSearchByName", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlCommand cmd1 = new SqlCommand("dbo.getReviews", conn1);
        cmd1.CommandType = CommandType.StoredProcedure;

        SqlCommand cmd2 = new SqlCommand("dbo.ViewAnnouncements", conn2);
        cmd2.CommandType = CommandType.StoredProcedure;

        conn.Open();
        conn1.Open();
        conn2.Open();

        string input = nameinput.Text;

        cmd.Parameters.Add(new SqlParameter("@name", input));
        cmd1.Parameters.Add(new SqlParameter("@sname", input));
        cmd2.Parameters.Add(new SqlParameter("@sname", input));

        //IF the output is a table, then we can read the records one at a time
        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
        SqlDataReader rdr2 = cmd2.ExecuteReader(CommandBehavior.CloseConnection);

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
            eg.Text = "End Grade: " + endgrade.ToString() + "</br></br>";
            PlaceHolder1.Controls.Add(eg);

            while (rdr1.Read())
            {
                i = i + 1;
                string review = rdr1.GetString(rdr1.GetOrdinal("reviews"));
                Label rv = new Label();
                rv.Text = "Review " + i +": " + review + "</br>";
                PlaceHolder1.Controls.Add(rv);
            }

            Label hr = new Label();
            hr.Text = "<hr>";
            PlaceHolder1.Controls.Add(hr);

            while (rdr2.Read())
            {
                z = z + 1;
                string anndes = rdr2.GetString(rdr2.GetOrdinal("ann_description"));
                Label ann = new Label();
                ann.Text = "Announcement: " + z + ": " + anndes + "</br>";
                PlaceHolder1.Controls.Add(ann);
            }

            Label hr1 = new Label();
            hr1.Text = "<hr>";
            PlaceHolder1.Controls.Add(hr1);
        }
    }
}