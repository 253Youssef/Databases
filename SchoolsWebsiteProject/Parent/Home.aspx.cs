using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parent_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label x = new Label();
        x.Text = "Parent: " + (string)(Session["username"]);
        ParentName.Controls.Add(x);
    }
}