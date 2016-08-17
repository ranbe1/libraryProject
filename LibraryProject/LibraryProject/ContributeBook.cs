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
    public partial class ContributeBook : Form
    {
        BooksBLL bll = new BooksBLL();
        public ContributeBook()
        {
            InitializeComponent();
        }

        private void ContributeButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you wish to contribute this book?", "Loan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bll.addBook(BookNameTb.Text,BookYearTb.Text,BookSummaryTb.Text,BookSubjectCb.Text);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LibraryHall hall = new LibraryHall();
            this.Hide();
            hall.ShowDialog();
            this.Close();
        }
    }
}
