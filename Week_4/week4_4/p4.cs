using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            count = 0;
            txtCount.Text = "0";
        }
        else
        {
            count = Convert.ToInt32(txtCount.Text);
        }
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(txtPassword.Text != "abcd")
        {
            //txtCount.Text += "a";
            //int.TryParse(txtCount.Text, out count);
            count++;
            txtCount.Text = count.ToString();
        }
        else
        {
            txtCount.Text = "0";
        }
        if(count == 3)
        {
            txtPassword.Enabled = false;
        }
    }
}