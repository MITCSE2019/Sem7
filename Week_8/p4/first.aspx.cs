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
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=employee;Integrated Security=True;Pooling=False";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=employee;Integrated Security=True;Pooling=False";
        string name, comp, street, city;
        int sal;
        name = TextBox1.Text;
        comp = TextBox2.Text;
        int.TryParse(TextBox3.Text, out sal);
        street = TextBox4.Text;
        city = TextBox5.Text;
        var insertCommand = "INSERT INTO works (person_name, Company, Salary) Values(@1, @2, @3)";
        var insertCommand2 = "INSERT INTO lives (person_name, Street, City) Values(@6, @4, @5)";
        SqlCommand command = new SqlCommand(insertCommand, con);
        SqlCommand command2 = new SqlCommand(insertCommand2, con);
        command.Parameters.AddWithValue("@1", name);
        command.Parameters.AddWithValue("@2", comp);
        command.Parameters.AddWithValue("@3", sal);
        command2.Parameters.AddWithValue("@4", street);
        command2.Parameters.AddWithValue("@5", city);
        command2.Parameters.AddWithValue("@6", name);
        try
        {
            con.Open();
            int added1,added2;
            added1 = command.ExecuteNonQuery();
            added2 = command2.ExecuteNonQuery();
            Result.Text = added1.ToString() + " records inserted in works and ." + added2.ToString() + "records inserted in lives.";
            //var insertCommand = "INSERT INTO works (person_name, Company, Salary) Values(@1, @2, @3)";
            //SqlCommand cmd = new SqlCommand(insertCommand, con);
        }
        catch (Exception ex )
        {

        }
        finally
        {
            con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=employee;Integrated Security=True;Pooling=False";
        con.Open();
        string comp = TextBox6.Text;
        string sql = "Select lives.person_name,City from lives join works on works.person_name=lives.person_name where Company='" + comp + "'";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = System.Data.CommandType.Text;

        using (SqlDataReader dr = cmd.ExecuteReader())
        {
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }

        con.Close();
    }
}