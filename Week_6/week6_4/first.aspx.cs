using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class first : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage m1 = (MasterPage)Master;
        m1.change = "Mobiles";
        mobile_list.Items.Add(new ListItem("iPhone 8", "A11 bionic,256GB,12MP,1821 mAh"));
        mobile_list.Items.Add(new ListItem("pixel 2", "SD835,128GB,30MP,3000mAh"));
        mobile_list.Items.Add(new ListItem("one plus 6", "SD845,64GB,20MP camera,4000mAh"));
    }
    protected void Page_PreInit(Object s, EventArgs e)
    {
        Page.Theme = "Theme1";
    }

    protected void clickevent(object sender, EventArgs e)
    {
        Session["mobile_name"] = mobile_list.SelectedItem.ToString();
        Session["mobile_info"] = mobile_list.Items[mobile_list.SelectedIndex].Value;

        MasterPage m1 = (MasterPage)Master;
        m1.change = Session["mobile_name"].ToString();
        Response.Redirect("second.aspx");
    }
}