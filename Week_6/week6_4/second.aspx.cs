using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class second : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["mobile_name"]!=null && Session["mobile_info"]!=null)
        {
            MasterPage m1 = (MasterPage)Master;
            m1.change = Session["mobile_name"].ToString();
            mobileinfo.Text = Session["mobile_info"].ToString();
            
        }
    }
    protected void Page_PreInit(Object s, EventArgs e)
    {
        Page.Theme = "Theme1";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("first.aspx");
    }
}