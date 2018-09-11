using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
public partial class Form1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Session["count"] = 0;
            Application["users"] = 0;
        }
    }
 
    protected void Button2_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string pass = TextBox2.Text;
        if (string.Compare(pass, "pass123")==0)
        {
            Label3.Text = "You have tried " + Session["count"] + "times";
            Session["count"] = 0;
            int c = (int)Application["users"];
            c++;
            Application["users"] = c;
            Label4.Text = "Total Logins " + Application["users"];
        }
        else
        {
            int count = (int)Session["count"];
            count++;
            Session["count"] = count;
            Label3.Text = "You have tried " + Session["count"] + "times";
            if (count>3)
            {
                Label3.Text = Session["count"] + " Login Attempts Failed";
                TextBox2.ReadOnly = true;
            }
        }
    }
 
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
 
    }
 
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
 
    }
}
