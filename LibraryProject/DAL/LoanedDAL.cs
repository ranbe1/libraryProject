using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LoanedDAL
    {

        public string conString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        SqlConnection con = new SqlConnection();

        public DataTable LoanedByUser(string Username)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT From_Date,Book_Name FROM LoanedBooks WHERE Cust_Username='" + Username + "'", con);
            DataTable dt = new DataTable();

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            return dt;
        }

        public void ReturnBook(string Username,string Bookname)
        {

            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Books SET Copies = Copies + 1 WHERE Book_Name='" + Bookname + "'", con);
            SqlCommand cmd2 = new SqlCommand("DELETE FROM LoanedBooks WHERE Cust_Username='"+Username+"' AND Book_Name='" + Bookname + "'",con);
            SqlCommand cmd3 = new SqlCommand("UPDATE Customers SET Loaned = Loaned - 1 WHERE Cust_Username='" + Username + "'", con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
        }
            

        public DataTable LoadLoanedBooks(string Username)
        {

            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Book_Name FROM LoanedBooks WHERE Cust_Username='"+Username+"'", con);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);
            return dt;
        }

        public DataTable getLoanedDates(string Username,string Bookname)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT From_Date FROM LoanedBooks WHERE Cust_Username='" + Username + "' AND Book_Name='"+Bookname+"'", con);
            DataTable dt = new DataTable();

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            return dt;
        }
            

            
    }
}
