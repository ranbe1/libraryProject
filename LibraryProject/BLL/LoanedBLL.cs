using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class LoanedBLL
    {

        public bool checkDaysForLoans(string Username)
        {
            LoanedDAL dalobj = new LoanedDAL();

            DataTable dt = dalobj.LoanedByUser(Username);
            DateTime now = DateTime.Now;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan span = now.Subtract(Convert.ToDateTime(dt.Rows[i][0]));
                if (Math.Abs(Convert.ToInt32(span.Days)) >= 6)
                    return true;
            }

            return false;
        }

        public void returnBook(string Username, string Bookname)
        {
            LoanedDAL dalobj = new LoanedDAL();

            dalobj.ReturnBook(Username, Bookname);

        }


        public void loadLoanedBooks(string[] loanedBooks, string Username)
        {
            LoanedDAL dalobj = new LoanedDAL();

            DataTable dt = dalobj.LoadLoanedBooks(Username);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                loanedBooks[i] = dt.Rows[i][0].ToString();
            }
        }

        public bool checkIfLoanedAlready(string Username,string Bookname)
        {
            LoanedDAL dalobj = new LoanedDAL();
            DataTable dt = dalobj.LoadLoanedBooks(Username);
            bool check = false;            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Bookname == dt.Rows[i][0].ToString())
                    check = true;
            }
            return check;
        }
           

        public string getLoanedDates(string Username,string Bookname)
        {
            LoanedDAL dalobj = new LoanedDAL();
            DataTable dt = dalobj.getLoanedDates(Username, Bookname);

            return dt.Rows[0][0].ToString();
        }
            

    }
}
