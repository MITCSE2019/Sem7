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
        if(!IsPostBack)
        {
            List<string> fruit = new List<string>();
            fruit.Add("Apple");
            fruit.Add("Orange");
            fruit.Add("Banana");
            fruit.Add("Pineapple");
            fruit.Add("Guava");

            List<string> ic = new List<string>();
            ic.Add("Vanilla");
            ic.Add("Chocolate");
            ic.Add("Mango");
            ic.Add("Pista");
            ic.Add("Butterscotch");

            CheckBoxList1.DataSource = fruit;
            RadioButtonList1.DataSource = ic;

            this.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Random r = new Random();
        Label1.Text = " ";
        foreach ( ListItem i in CheckBoxList1.Items )
        {
            if( i.Selected == true )
            {
                Label1.Text += i.Value.ToString() + " ";
            }
        }
        Label1.Text += RadioButtonList1.SelectedValue.ToString() + " " + r.Next(10, 100);
    }
}