using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class AdminBoard : Form
    {
        public AdminBoard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOptions userControl = new AdminOptions();
            userControl.Show();
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
