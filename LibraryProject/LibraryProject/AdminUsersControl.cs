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
    public partial class AdminOptions : Form
    {
        CustomersBLL bll = new CustomersBLL();
        string Username;
        bool MakeAdmin = false;
        bool Kick = false; 


        public AdminOptions()
        {
            InitializeComponent();
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Username = UsernameTb.Text;
            int Kicked;
            int gotAdmin;
            if (Kick)
            {
                Kicked = bll.DeleteAcc(Username);

                if (Kicked == 0)
                {
                    MessageBox.Show("The user has been kicked.");
                }
                else if(Kicked == 1)
                {
                    MessageBox.Show("User doesnt exist.");
                }
                else
                {
                    MessageBox.Show("You cannot kick another admin!");
                }
            }
            else if(MakeAdmin)
            {
                gotAdmin = bll.AddAdmin(Username);
                if(gotAdmin == 0)
                {
                    MessageBox.Show("New admin!");
                }
                else if(gotAdmin == 1)
                {
                    MessageBox.Show("User doesnt exist.");
                }
                else
                {
                    MessageBox.Show("Already admin...");
                }
            }

        }

        private void MakeAdminRadio_CheckedChanged(object sender, EventArgs e)
        {
            MakeAdmin = true;
            Kick = false;
        }

        private void KickRadio_CheckedChanged(object sender, EventArgs e)
        {
            Kick = true;
            MakeAdmin = false;
        }
    }
}
