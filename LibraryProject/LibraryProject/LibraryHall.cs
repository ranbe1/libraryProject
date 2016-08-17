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
    public partial class LibraryHall : Form
    {

        LoanedBLL lbll = new LoanedBLL();

        public LibraryHall()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome " + Login.customer.Name;
            if (Login.customer.Type != 'A')
            {
                AdminButton.Hide();
            }
            if (lbll.checkDaysForLoans(Login.customer.Username))
               MessageBox.Show("You have not yet returned a book after a week!");
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminBoard board = new AdminBoard();
            this.Hide();
            board.ShowDialog();
            this.Close();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BooksLibraryButton_Click(object sender, EventArgs e)
        {
            BooksLibrary library = new BooksLibrary();
            this.Hide();
            library.ShowDialog();
            this.Close();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
           BookReturn ret = new BookReturn();
            this.Hide();
            ret.ShowDialog();
            this.Close();

        }

        private void ContributeButton_Click(object sender, EventArgs e)
        {
            ContributeBook contribute = new ContributeBook();
            this.Hide();
            contribute.ShowDialog();
            this.Close();
        }
    }
}
