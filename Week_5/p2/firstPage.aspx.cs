using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class firstPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("English", "English"));
            DropDownList1.Items.Add(new ListItem("Hindi", "Hindi"));
            DropDownList1.Items.Add(new ListItem("Mathematics", "Mathematics"));
            DropDownList1.Items.Add(new ListItem("Science", "Science"));
            DropDownList1.Items.Add(new ListItem("Social Science", "Social Science"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Subject"] = TextBox1.Text +  "  " + TextBox2.Text + "  "+ DropDownList1.Items[DropDownList1.SelectedIndex].Value;
        Response.Redirect("secondPage.aspx");
    }
}