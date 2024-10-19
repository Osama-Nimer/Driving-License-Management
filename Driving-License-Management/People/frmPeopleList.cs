using BuisnessLayer;
using Driving_License_Management.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmPeopleList : Form
    {
        private static DataTable _dt = clsPepoleBuisness._GetAllPepole();

        private DataTable _dtPeople = _dt.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");


        public frmPeopleList()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new AddPerson();

            frm.ShowDialog();
        }
        private void _RefreshPeoplList()
        {
            _dt = clsPepoleBuisness._GetAllPepole();
            _dtPeople = _dt.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            lbRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lbRecords.Text = dgvPeople.RowCount.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;
                case "FirstName":
                    FilterColumn = "FirstName";
                    break;
                case "SecondName":
                    FilterColumn = "SecondName";
                    break;
                case "ThirdName":
                    FilterColumn = "ThirdName";
                    break;
                case "LastName":
                    FilterColumn = "LastName";
                    break;
                case "CountryName":
                    FilterColumn = "CountryName";
                    break;
                case "GendorCaption":
                    FilterColumn = "GendorCaption";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                default:
                case "None":
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbRecords.Text = dgvPeople.Rows.Count.ToString();
                return;
            }
            try
            {
                if (FilterColumn == "PersonID")
                    //in this case we deal with integer not string.
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                else
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }
            catch (Exception ex)
            {

            }
            lbRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void showPersonDaetalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson frm = new AddPerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson frm = new AddPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPepoleBuisness._DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
