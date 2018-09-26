using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (localdb)\\MSSQLlocalDB;Initial Catalog=week7_4;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";

            try
            {
                con.Open();
                string q = "SELECT distinct company_name FROM WORKS";
                SqlCommand query = new SqlCommand(q, con);
                query = new SqlCommand(q, con);
                SqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    s_company.Items.Add(new ListItem(reader["company_name"].ToString(), reader["company_name"].ToString()));
                }
            }
            catch (Exception ex)
            {
                Button1.Text = ex.ToString();
            }
            finally
            {
                //close
                con.Close();
            }
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source = (localdb)\\MSSQLlocalDB;Initial Catalog=week7_4;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
        
        try
        {
            //open
            con.Open();



            string q = "INSERT INTO WORKS VALUES ('" + p_name.Text + "','" + p_company.Text + "','" + salary.Text + "')";
            SqlCommand query = new SqlCommand(q,con);
            query.ExecuteNonQuery();

            q = "INSERT INTO LIVES VALUES ('" + p_name.Text + "','" + p_street.Text + "','" + pcity.Text + "')";
            query = new SqlCommand(q, con);
            query.ExecuteNonQuery();

            q = "SELECT * FROM WORKS WHERE person_name='"+p_name.Text+"'";
            query = new SqlCommand(q, con);
            SqlDataReader reader1 = query.ExecuteReader();

            
            q = "SELECT * FROM LIVES WHERE person_name='" + p_name.Text + "'";
            query = new SqlCommand(q, con);
            SqlDataReader reader2 = query.ExecuteReader();


            if (reader1.HasRows && reader2.HasRows)
            {
                res1.Text+= "Success";
            }
            else
            {
                res1.Text+= "Not added";
            }
        }
        catch (Exception ex)
        {
            Button1.Text = ex.ToString();            
        }
        finally
        {
            //close
            con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source = (localdb)\\MSSQLlocalDB;Initial Catalog=week7_4;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";

        try
        {
            //open

            con.Open();

            string q = "SELECT * FROM WORKS as W,LIVES as L WHERE W.person_name=L.person_name AND W.company_name = '"+s_company.Items[s_company.SelectedIndex].Value+"'";
            SqlCommand query = new SqlCommand(q, con);          
            query = new SqlCommand(q, con);
            SqlDataReader reader = query.ExecuteReader();
            res2.Text = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res2.Text+=reader["person_name"].ToString() + reader["company_name"].ToString() + reader["salary"].ToString() + "</br>";
                }
            }
            else
            {
                res2.Text = "No result";
            }
        }
        catch (Exception ex)
        {
            Button1.Text = ex.ToString();
        }
        finally
        {
            //close
            con.Close();
        }
    }
}