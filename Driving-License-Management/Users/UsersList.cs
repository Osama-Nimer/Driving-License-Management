using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Users
{
    public partial class UsersList : Form
    {

        private static DataTable _dt;

        public UsersList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            UsersList_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDaetalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            _dt = User._GetAllUser();
            dgvUsers.DataSource = _dt;
            cbFilterBy.SelectedIndex = 0;

            lbRecords.Text = dgvUsers.Rows.Count.ToString();

            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 350;

            dgvUsers.Columns[3].HeaderText = "UserName";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 120;


        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;


                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Username":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dt.DefaultView.RowFilter = "";
                lbRecords.Text = dgvUsers.Rows.Count.ToString();
                return;
            }
            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lbRecords.Text = _dt.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dt.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lbRecords.Text = _dt.Rows.Count.ToString();


        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser();
            Frm1.ShowDialog();
            UsersList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            UsersList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (User._DeleteUesr(UserID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsersList_Load(null, null);
            }

            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmChangePassword Frm1 = new frmChangePassword(UserID);
            Frm1.ShowDialog();
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserInfo Frm1 = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }
    }
}
