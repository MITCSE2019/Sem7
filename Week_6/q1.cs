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
 
    }
 
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string num = TextBox3.Text;
        int i, no = 0;
 
        try
        {
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] >= '0' && num[i] <= '9')
                    no++;
            }
            if (num.Length == 10 && no == num.Length)
            {
                args.IsValid = true;
            }
            else
                args.IsValid = false;
        }catch
        {
            args.IsValid = false;
        }
    }
 
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RequiredFieldValidator1.IsValid && RequiredFieldValidator2.IsValid && RequiredFieldValidator3.IsValid && RequiredFieldValidator4.IsValid &&
            RangeValidator1.IsValid && RegularExpressionValidator1.IsValid && CustomValidator1.IsValid)
            Label4.Text = "SUCCESS";
        else
            Label4.Text = "FAILURE";
    }
}
