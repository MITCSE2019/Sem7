using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
           
            DropDownList1.Items.Add(new ListItem("D", @"D:\"));
           DropDownList1.Items.Add(new ListItem("C", @"C:\"));
            // DropDownList1.Items.Add(new ListItem("E", @"E:\"));
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string item = DropDownList1.Items[DropDownList1.SelectedIndex].Value;
        DriveInfo di = new System.IO.DriveInfo(item);
        DirectoryInfo d = di.RootDirectory;//Assuming Test is your Folder
        
        FileInfo[] Files = d.GetFiles("*.*"); //Getting all files
        DirectoryInfo[] dInfo = d.GetDirectories("*.*");
        string str = "";
        foreach (FileInfo file in Files)
        {
            str = str + ", " + file.Name;
            ListBox1.Items.Add(new ListItem(file.Name, file.Name));
        }
        foreach (DirectoryInfo file in dInfo)
        {
            str = str + ", " + file.Name;
            ListBox1.Items.Add(new ListItem(file.Name, file.Name));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string item = DropDownList1.Items[DropDownList1.SelectedIndex].Value +@"\" +ListBox1.Items[ListBox1.SelectedIndex];
        Directory.Delete(item);
        DriveInfo di = new System.IO.DriveInfo(item);
        DirectoryInfo d = di.RootDirectory;//Assuming Test is your Folder

        FileInfo[] Files = d.GetFiles("*.*"); //Getting all files
        DirectoryInfo[] dInfo = d.GetDirectories("*.*");
        string str = "";
        ListBox1.Items.Clear();
        foreach (FileInfo file in Files)
        {
            str = str + ", " + file.Name;
            ListBox1.Items.Add(new ListItem(file.Name, file.Name));
        }
        foreach (DirectoryInfo file in dInfo)
        {
            str = str + ", " + file.Name;
            ListBox1.Items.Add(new ListItem(file.Name, file.Name));
        }
    }
}
