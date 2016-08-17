using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BooksDAL
    {

        public string conString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        SqlConnection con = new SqlConnection();

        public DataTable Load_Subject(string subjectName)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Subject='" + subjectName + "'",con);
            DataTable dt =  new DataTable();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);

            return dt;
        }

        public void Loan_Book(string bookName,string Username)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            DateTime date = DateTime.Now;
            string dateForTable = date.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("UPDATE Books SET Copies = Copies-1 WHERE Book_Name='"+bookName+"'"  , con);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO LoanedBooks VALUES ('" + bookName + "','" + Username + "','" + dateForTable + "')",con);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

        }

        public void AddBook(string Bookname,string Bookyear,string Booksummary,string Booksubject)
        {
            con.ConnectionString = conString;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Books SET Copies = Copies+1 WHERE Book_Name='"+Bookname+"'", con);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Books VALUES('"+Bookname+"','"+Bookyear+"','"+Booksummary+"','"+Booksubject+"','"+'1'+"')",con);

            if (!(cmd.ExecuteNonQuery() > 0))
                cmd2.ExecuteNonQuery();
        }


    }
}
