using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secondPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = (string)Session["Subject"];
            if (Request.Cookies["cnt"] == null)
            {
                Label2.Text = "0";
            }
            else
            {
                //int cnt;
                //int.TryParse(Request.Cookies["cnt"].Value, out cnt);
                Label2.Text = Request.Cookies["cnt"].Value;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int cnt;
        int.TryParse(Label2.Text, out cnt);
        cnt++;
        Response.Cookies["cnt"].Value = cnt.ToString();
        Response.Redirect("secondPage.aspx");
    }
}