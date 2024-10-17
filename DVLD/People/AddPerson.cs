using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;
using DVLD.Properties;

namespace DVLD.People
{
    public partial class AddPerson : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        enum enMode
        {
            AddNew = 0,
            Update = 1
        };
        enum enGender
        {
            Male = 0,
            Female = 1
        };
        private enMode _Mode;
        private int _PersonID = -1;
        clsPepoleBuisness _Person;

        public AddPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public AddPerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void ResetDefultValues()
        {
            FillCountries();
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPepoleBuisness();
            }
            else
                lblTitle.Text = "Update Person";

            if (rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Male_512;
            }
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }


        private void FillCountries()
        {
            DataTable dt = Country._GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cbCountry.Items.Add(dr["CountryName"]);
            }
        }

        private void LoadData()
        {
            _Person = clsPepoleBuisness.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtEmail.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtNationalNo.Text = _Person.NationalNo;

            if (_Person.Gendor == 0)
                rbMale.Enabled = true;
            else
                rbFemale.Enabled = true;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }

            llRemoveImage.Visible = (_Person.ImagePath != "");

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            ResetDefultValues();
            if(_Mode == enMode.Update)
            {
                LoadData();
            }
        }



    }
}
