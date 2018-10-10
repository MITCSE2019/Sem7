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

    }
    protected void GridView1_RowDataBound( object sender, GridViewRowEventArgs e )
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int age = (int)DataBinder.Eval(e.Row.DataItem, "Age");
            if (age > 35)
            {
                e.Row.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}