using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace LibraryProject
{

    public partial class BooksLibrary : Form
    {
        const int countTopics = 7;
        const int maxBooks = 100;
        Subject[] subjects = new Subject[countTopics];
        BooksBLL bll = new BooksBLL();
        CustomersBLL custbll = new CustomersBLL();
        LoanedBLL loanedbll = new LoanedBLL();
        Subject currSubject;

        public BooksLibrary()
        {
            InitializeComponent();
            string[] subjectsNames = new string[countTopics];
            for (int i = 0; i < countTopics; i++)
            {
                subjectsNames[i] = subjectsLb.Items[i].ToString();

            }
            bll.Load_Books(subjects, subjectsNames);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TopicsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectsLb.SelectedItem != null)
            {
                currSubject = SearchSubject(subjectsLb.SelectedItem.ToString(), subjects);

                if (BooksLb.Items.Count > 0) BooksLb.Items.Clear();

                BooksLb.Items.AddRange(currSubject.Books);
            }
        }

        private void BooksLibrary_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LibraryHall hall = new LibraryHall();
            this.Hide();
            hall.ShowDialog();
            this.Close();
        }

        private void BooksLb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (BooksLb.SelectedItem != null)
                printBook(currSubject.SearchBookByName(BooksLb.SelectedItem.ToString()));
        }

        private void LoanButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you wish to loan this book?", "Loan", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            bool loanedAlready = loanedbll.checkIfLoanedAlready(Login.customer.Username, BooksLb.SelectedItem.ToString());
            Book book=null;
            if (BooksLb.SelectedItem != null)
                 book = currSubject.SearchBookByName(BooksLb.SelectedItem.ToString());
            if (book != null)
            {
                if (result == DialogResult.Yes && book.Copies > 0 &&
                            Login.customer.Loaned < maxBooks && loanedAlready == false)
                {
                    custbll.updateLoans(Login.customer.Username);
                    Login.customer.Loaned += 1;
                    bll.Loan_Book(currSubject.SearchBookByName(BooksLb.SelectedItem.ToString()),Login.customer.Username);
                    book.Copies -= 1;
                    printBook(book);

                    MessageBox.Show("Enjoy! you have 1 week to return the book.");
                }
                else if (result == DialogResult.Yes && book.Copies == 0)
                {
                    MessageBox.Show("Sorry there are no copies left from this book atm.");
                }
                else if(result == DialogResult.Yes && Login.customer.Loaned >= maxBooks)
                {
                    MessageBox.Show("Sorry but you already loaned "+ maxBooks + " books , return at least 1 first!");
                }
                else if(loanedAlready)
                {
                    MessageBox.Show("Sorry but you already loaned this book!");
                }
            }
        }


        private Subject SearchSubject(string subjectName, Subject[] subjects)
        {
            Subject subject = null;
            for (int i = 0; i < subjects.Count(); i++)
            {
                if (subjects[i] != null)
                    if (subjects[i].Name == subjectName)
                        subject = subjects[i];

            }
            return subject;
        }

        void printBook(Book bookToPrint)
        {
            if (bookToPrint != null)
            {
                SummaryTb.Clear();
                SummaryTb.Text += "Year: " + bookToPrint.Year;
                SummaryTb.Text += "\nSummary:" + bookToPrint.Summary;
                SummaryTb.Text += "\nCopies left: " + bookToPrint.Copies + "\n";
            }
        }
    }
}
