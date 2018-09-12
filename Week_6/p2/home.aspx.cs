using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Mobile", "Mobile"));
            DropDownList1.Items.Add(new ListItem("Laptop", "Laptop"));
            DropDownList1.Items.Add(new ListItem("Printer", "Printer"));
        }
    }
}