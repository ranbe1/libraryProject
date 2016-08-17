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
    public partial class Login : Form
    {

        private CustomersBLL bll = new CustomersBLL();
        private DataTable dt = new DataTable();
        public static Customer customer;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameTb.Text;
            string Password = PasswordTb.Text;

            customer = bll.Verify_Login(Username,Password);

            if (customer != null)
            {
                LibraryHall hall = new LibraryHall();
                this.Hide();
                hall.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is wrong.");
            }
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }

        private void UsernameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
