using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Products;Integrated Security=True;Pooling=False";
        con.Open();
        string id = TextBox1.Text;
        string price = TextBox2.Text;
        int i, j;
        int.TryParse(id, out i);
        int.TryParse(price, out j);
        string sql = "Update Items set price = " + j + "where itemID = " + i;
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        //Label1.Text = a.ToString();
        cmd.CommandType = System.Data.CommandType.Text;

        /*using (SqlDataReader dr = cmd.ExecuteReader())
        {
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }*/

        con.Close();
    }
}
