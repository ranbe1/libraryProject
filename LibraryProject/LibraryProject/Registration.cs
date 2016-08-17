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
    public partial class Registration : Form
    {
        CustomersBLL bll = new CustomersBLL();    
        DataTable dt = new DataTable();
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string Name = NameTb.Text;
            string Password = PasswordTb.Text;
            string Username = UsernameTb.Text;
            bool registerSuccesfully = bll.Register(Name, Username, Password);

            if (registerSuccesfully)
                MessageBox.Show("Registered");
            else
                MessageBox.Show("Username already exists.");

        }
    }
}
