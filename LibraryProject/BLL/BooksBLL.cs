using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class BooksBLL
    {
        public void Load_Books(Subject[] subjects, string[] topicsNames)
        {
            //int count = 0;
            for (int i = 0; i < subjects.Count(); i++)
            {
                
                BooksDAL b = new BooksDAL();
                DataTable dt = b.Load_Subject(topicsNames[i]);
                subjects[i] = new Subject(dt.Rows.Count);
                subjects[i].Name = topicsNames[i];
                if (dt.Rows.Count > 0)
                {
                    //topics[i] = new Topic(dt.Rows.Count);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        subjects[i].Books[j] = new Book(dt.Rows[j][1].ToString(), dt.Rows[j][4].ToString(),
                            (int)dt.Rows[j][2], dt.Rows[j][3].ToString(), (int)dt.Rows[j][5]);
                    }
                    //count++;
                }
            }
        }

        public void Loan_Book(Book book,string Username)
        {
            BooksDAL b = new BooksDAL();

            b.Loan_Book(book.Name,Username);
        }

        public void addBook(string Bookname, string Bookyear, string Booksummary, string Booksubject)
        {
            BooksDAL b = new BooksDAL();

            b.AddBook(Bookname,Bookyear,Booksummary,Booksubject);
        }

    }
}
