using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string i = Request.QueryString["Item"];
        string j = Request.QueryString["Mode"];
        TextBox1.Text = i;
        TextBox2.Text = j;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
}