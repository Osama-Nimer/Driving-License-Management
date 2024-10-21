using BuisnessLayer;
using Driving_License_Management.Global_Classes;
using DVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Login_Page
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (Global.GetStoredCredential(ref UserName, ref Password))
            {
                txtUsername.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user =User.FindUserbyUserNameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    Global.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    Global.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txtUsername.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Global.CurrentUser = user;
                this.Hide();
                Form1 frm = new Form1(this);
                frm.ShowDialog();


            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
