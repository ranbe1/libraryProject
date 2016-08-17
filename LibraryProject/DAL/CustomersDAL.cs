using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class CustomersDAL
    {
        public string conString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        

        public DataTable Login(string Username,string Password)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers where Cust_Username='"+ Username + "' and Cust_Password='"+Password+"'", con);
            DataTable dt = new DataTable();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);

            con.Close();

            return dt;

        }

        public int Register(string Name,string Username, string Password)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers VALUES ('"+Name+"','"+Username+"','"+Password+"','"+'C'+"','"+'0'+"')", con);

            int rows_affected = -1;
            rows_affected = cmd.ExecuteNonQuery();
            con.Close();
            return rows_affected;
            
        }

        public Boolean checkExistCust(string Username)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers where Cust_Username = '"+ Username + "'", con);
            DataTable dt = new DataTable();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            if (dt.Rows.Count == 0)
                return false;

            return true;

        }

        public void addAdmin()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAcc(string Username)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers where Cust_Username='" + Username + "' and Type='" + 'C' + "'", con);
            DataTable dt = new DataTable();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            if(dt.Rows.Count > 0)
            {
               SqlCommand cmd2 = new SqlCommand("DELETE FROM Customers where Cust_Username = '" + Username + "'", con);
               cmd2.ExecuteNonQuery();
               con.Close();
               return true;
            }
            con.Close();
            return false;
        }

        public bool AddAdmin(string Username)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers where Cust_Username='" + Username + "' and Type='" + 'A' + "'", con);
            DataTable dt = new DataTable();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);

            if (dt.Rows.Count > 0)
               return false;

            SqlCommand cmd2 = new SqlCommand("UPDATE Customers SET Type='"+'A'+"'", con);
            cmd2.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public void UpdateLoans(string Username)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customers SET Loaned = Loaned + 1 WHERE Cust_Username='" + Username + "'", con);

            cmd.ExecuteNonQuery();
        }

    }
}
