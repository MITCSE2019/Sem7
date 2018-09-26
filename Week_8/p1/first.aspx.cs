using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class first : System.Web.UI.Page
{
    static DataSet ds = new DataSet();
    static SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        if (!IsPostBack )
        {
            ListBox1.Items.Add(new ListItem("Bangalore", "Bangalore"));
            ListBox1.Items.Add(new ListItem("Mumbai", "Mumbai"));
            ListBox1.Items.Add(new ListItem("Delhi", "Delhi"));
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
        int t;
        int.TryParse(DropDownList1.SelectedValue, out t);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff where StaffID = " + t, con );
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "emp_data");
            con.Close();
            foreach( DataRow st in ds.Tables["emp_data"].Rows)
            {
                TextBox1.Text = st["FirstName"].ToString();
                TextBox2.Text = st["LastName"].ToString();
                TextBox3.Text = st["DNo"].ToString();
                TextBox4.Text = st["Street"].ToString();
                TextBox5.Text = st["City"].ToString();
                TextBox6.Text = st["State"].ToString();
                TextBox7.Text = st["ZipCode"].ToString();
            }
        }
        catch( Exception ex )
        {

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string t = ListBox1.SelectedValue;
        DataTable dt = ds.Tables["emp_data"];
        dt.Rows[0]["City"] = t;
        SqlCommandBuilder bd = new SqlCommandBuilder(adp);
        bd.GetUpdateCommand();
        adp.Update(ds, "emp_data");
    }
}