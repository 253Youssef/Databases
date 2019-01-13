using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_EditSchool : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("dbo.AdminViewSchool", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));

        
        //IF the output is a table, then we can read the records one at a time
        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        while (rdr.Read())
        {
            //Get the value of the attribute name in the Schools table
            string name = rdr.GetString(rdr.GetOrdinal("name"));
            string address_home = rdr.GetString(rdr.GetOrdinal("address_home"));
            int phone_num = rdr.GetInt32(rdr.GetOrdinal("phone_num"));
            string gen_information = rdr.GetString(rdr.GetOrdinal("gen_information"));
            string vision = rdr.GetString(rdr.GetOrdinal("vision"));
            string mission = rdr.GetString(rdr.GetOrdinal("mission"));
            string main_language = rdr.GetString(rdr.GetOrdinal("main_language"));
            string s_type = rdr.GetString(rdr.GetOrdinal("s_type"));
            int fees = rdr.GetInt32(rdr.GetOrdinal("fees"));
            int begin_grade = rdr.GetInt32(rdr.GetOrdinal("begin_grade"));
            int end_grade = rdr.GetInt32(rdr.GetOrdinal("end_grade"));



            Label sname = new Label();
            sname.Text = "Name: " + name + "</br>";
            PlaceHolder2.Controls.Add(sname);

            Label saddress = new Label();
            saddress.Text = "Address: " + address_home + "</br>";
            PlaceHolder2.Controls.Add(saddress);

            Label sphone = new Label();
            sphone.Text = "Phone Number: " + phone_num.ToString() + "</br>";
            PlaceHolder2.Controls.Add(sphone);

            Label sinfo = new Label();
            sinfo.Text = "General Information: " + gen_information + "</br>";
            PlaceHolder2.Controls.Add(sinfo);

            Label svision = new Label();
            svision.Text = "Vision: " + vision + "</br>";
            PlaceHolder2.Controls.Add(svision);

            Label smision = new Label();
            smision.Text = "Mission: " + vision + "</br>";
            PlaceHolder2.Controls.Add(smision);

            Label slanguage = new Label();
            slanguage.Text = "Main Langauge: " + main_language + "</br>";
            PlaceHolder2.Controls.Add(slanguage);

            Label stype = new Label();
            stype.Text = "Type: " + s_type + "</br>";
            PlaceHolder2.Controls.Add(stype);

            Label sfees = new Label();
            sfees.Text = "Fees: " + fees.ToString() + "</br>";
            PlaceHolder2.Controls.Add(sfees);

            Label sbegin = new Label();
            sbegin.Text = "Begin Grade: " + begin_grade.ToString() + "</br>";
            PlaceHolder2.Controls.Add(sbegin);

            Label send = new Label();
            send.Text = "End Grade: " + end_grade.ToString() + "</br>";
            PlaceHolder2.Controls.Add(send);

            Label br = new Label();
            br.Text = "</br>";

            Label hr = new Label();
            hr.Text = "<hr>";

        }
    }

    public void buttonClick(object sender, System.EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        
        SqlCommand cmd = new SqlCommand("dbo.AdminEditSchool", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();

        string usernameexist = (string)(Session["username"]);
        string passexist = (string)(Session["password"]);

        string name = nname.Text;
        string saddress = address.Text;
        int sphone = Convert.ToInt32(phone.Text); 
        string semail = email.Text;
        string sinfo = info.Text;
        string svision = vision.Text;
        string smission = mission.Text;
        string slang = lang.Text;
        string stype = type.Text;
        int sfees = Convert.ToInt32(fee.Text);
        int bgrade = Convert.ToInt32(b_grade.Text);
        int egrade = Convert.ToInt32(e_grade.Text);

        cmd.Parameters.Add(new SqlParameter("@usernameexist", usernameexist));
        cmd.Parameters.Add(new SqlParameter("@passexist", passexist));
        cmd.Parameters.Add(new SqlParameter("@newname", name));
        cmd.Parameters.Add(new SqlParameter("@address_home", saddress));
        cmd.Parameters.Add(new SqlParameter("@phone_num", sphone));
        cmd.Parameters.Add(new SqlParameter("@email", semail));
        cmd.Parameters.Add(new SqlParameter("@gen_information", sinfo));
        cmd.Parameters.Add(new SqlParameter("@vision", svision));
        cmd.Parameters.Add(new SqlParameter("@mission", smission));
        cmd.Parameters.Add(new SqlParameter("@main_language", slang));
        cmd.Parameters.Add(new SqlParameter("@s_type", stype));
        cmd.Parameters.Add(new SqlParameter("@fees", sfees));
        cmd.Parameters.Add(new SqlParameter("@begin_grade", bgrade));
        cmd.Parameters.Add(new SqlParameter("@end_grade", egrade));


        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        Response.Redirect("/Admin/EditSchool");

    }

}