using Driving_License_Management.Global_Classes;
using Driving_License_Management.Login_Page;
using Driving_License_Management.Users;
using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
        LoginPage loginPage;
        public Form1(LoginPage frm)
        {
            InitializeComponent();
            loginPage = frm;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            frmPeopleList frm = new frmPeopleList();
            frm.ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            UsersList frm = new UsersList();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
