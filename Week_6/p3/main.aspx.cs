using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Summer", "Summer"));
            DropDownList1.Items.Add(new ListItem("Monsoon", "Monsoon"));
            if(Session["Theme"] != null )
            {
                DropDownList1.Items.FindByText(Session["Theme"].ToString()).Selected = true;
            }
        }
    }
    protected void Page_PreInit(object sender, EventArgs e )
    {
        if(Session["Theme"] != null )
        {
            Page.Theme = Session["Theme"].ToString();
        }
    }
    protected void DropDown1_SelectedIndexChanged( object sender, EventArgs e )
    {
        Session["Theme"] = DropDownList1.SelectedValue.ToString();
        Server.Transfer(Request.FilePath);
    }

    /*protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Theme"] = DropDownList1.SelectedValue;
        Server.Transfer(Request.FilePath);
    }*/
}