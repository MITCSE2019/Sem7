using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if( !IsPostBack )
        {
            DropDownList1.Items.Add(new ListItem("Honda", "Jazz"));
            DropDownList1.Items.Add(new ListItem("Audi", "Q5"));
            DropDownList1.Items.Add(new ListItem("Porche", "Cayman"));
            DropDownList1.Items.Add(new ListItem("Hyundai", "Creta"));
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string url = "Default2.aspx?";
        url += "Item=" + Server.UrlEncode(DropDownList1.SelectedItem.Text) + "&";
        url += "Mode=" + Server.UrlEncode(TextBox1.Text);
        Response.Redirect(url);
    }

    
}