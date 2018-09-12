using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class election : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if( !IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Ajay", "Ajay"));
            DropDownList1.Items.Add(new ListItem("Akash", "Akash"));
            DropDownList1.Items.Add(new ListItem("Pramod", "Pramod"));

            RadioButtonList1.Items.Add(new ListItem("Red", "A"));
            RadioButtonList1.Items.Add(new ListItem("Blue", "B"));
            RadioButtonList1.Items.Add(new ListItem("Green", "C"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            Label1.Text = "Page is valid!";
        }
        else
        {
            Label1.Text = "Invalid!";
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string n = TextBox3.Text;
        int i, l = 0;
        try
        {
            for( i = 0; i < n.Length; i++ )
            {
                if( n[i] >= '0' && n[i] <= '9' )
                {
                    l++;
                }
            }
            if( n.Length == 10 && l == 10 )
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        catch
        {
            args.IsValid = false;
        }
    }
}