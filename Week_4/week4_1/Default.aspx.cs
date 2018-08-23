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
            colordropdown.Items.Add(new ListItem("white", "white"));
            colordropdown.Items.Add(new ListItem("white", "black"));
            colordropdown.Items.Add(new ListItem("white", "red"));

            fontdropdown.Items.Add(new ListItem("12", "12"));
            fontdropdown.Items.Add(new ListItem("18", "18"));
            fontdropdown.Items.Add(new ListItem("22", "22"));

            backcolordropdown.Items.Add(new ListItem("red", "#FF0000"));
            backcolordropdown.Items.Add(new ListItem("blue", "#2C8FDB"));
            backcolordropdown.Items.Add(new ListItem("green", "#2EF241"));
        }
    }

    protected void colordropdown_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void generateCover(object sender, EventArgs e)
    {
        cover.BackImageUrl = FileUpload1.PostedFile.FileName;
        displaymessage.Text = msg.Text;

        string x = backcolordropdown.Items[backcolordropdown.SelectedIndex].Value;
        cover.BackColor = System.Drawing.ColorTranslator.FromHtml(x);

        displaymessage.Font.Size = int.Parse(fontdropdown.Items[fontdropdown.SelectedIndex].Value);

    }
}