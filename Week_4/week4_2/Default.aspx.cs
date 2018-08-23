using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            emp_id_dropdown.Items.Add(new ListItem("1001", "1001.jpg"));
            emp_id_dropdown.Items.Add(new ListItem("1002", "1002.jpg"));
            emp_id_dropdown.Items.Add(new ListItem("1003", "1003.jpg"));
        }
    }

    protected void checkeligibility(object sender, EventArgs e)
    {
        emp_img.ImageUrl = "~/"+emp_id_dropdown.Items[emp_id_dropdown.SelectedIndex].Value;
        TimeSpan duration = DateTime.Now - Calendar1.SelectedDate;
        int years = duration.Days / 365;
        if (years >=5)
        {
            eligible.Text = "YES";
        }
        else
        {
            eligible.Text = "NO";      
        }

    }
}