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
    public partial class BookReturn : Form
    {

        LoanedBLL bll = new LoanedBLL();
        

        public BookReturn()
        {
            InitializeComponent();
        }

        private void BookReturn_Load(object sender, EventArgs e)
        {
            string[] books = new string[Login.customer.Loaned];
            //List<string> boo = new List<string>();
            bll.loadLoanedBooks(books,Login.customer.Username);
            ReturnList.Items.AddRange(books);
           // ReturnList.Items.Add(boo);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LibraryHall hall = new LibraryHall();
            this.Hide();
            hall.ShowDialog();
            this.Close();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you wish to return this book?", "Loan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ReturnList.SelectedItem != null)
                {
                    bll.returnBook(Login.customer.Username, ReturnList.SelectedItem.ToString());
                    Login.customer.Loaned -= 1;
                    ReturnList.Items.Remove(ReturnList.SelectedItem.ToString());
                    returnBookTb.Clear();
                }
            }
        }

        private void ReturnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReturnList.SelectedItem != null)
            {
                DateTime startDate = Convert.ToDateTime(bll.getLoanedDates(Login.customer.Username, ReturnList.SelectedItem.ToString()));
                //TimeSpan dueDate = startDate.Add(DateTime.da);
                returnBookTb.Text = "From Date: " + startDate.ToString("dd/MM/yyyy")
                    +"\nTo Date: ";
            }

        }

        private void returnBookTb_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
