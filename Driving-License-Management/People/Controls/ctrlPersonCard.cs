using BuisnessLayer;
using Driving_License_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {

        private clsPepoleBuisness _Person;
        private int _PersonID = -1;
        public int PersonID { get => _PersonID; }

        public clsPepoleBuisness SelectedPersonInfo { get => _Person; }


        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPepoleBuisness.Find(PersonID);
            if (_Person == null)
            {
                //_ResetPersonInfp();
                MessageBox.Show($"No Person With ID {PersonID}", "Error");
                return;
            }
            _PersonID = PersonID;
            _FillPersonInfo();
            
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPepoleBuisness.Find(NationalNo);
            if (_Person == null)
            {
                _ResetPersonInfp();
                MessageBox.Show($"No Person With ID {NationalNo}", "Error");
                return;
            }
            _PersonID = _Person.PersonID;
            _FillPersonInfo();
        }

        public void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";

            var country = Country._Find(_Person.NationalityCountryID);
            if (country != null)
            {
                lblCountry.Text = country.CountryName;
            }
            else
            {
                lblCountry.Text = "Country not found";
            }

            _LoadPersonImage();
        }
        public void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
            string imagePath = _Person.ImagePath;
            if (imagePath != "")
                if (File.Exists(imagePath))
                    pbPersonImage.ImageLocation = imagePath;
                else
                    MessageBox.Show("Could not find this Image !! " + imagePath, "Error");
        }
        public void _ResetPersonInfp()
        {
            llEditPersonInfo.Enabled = false;
            lblPersonID.Text = "";
            lblFullName.Text = "";
            lblNationalNo.Text = "";
            lblEmail.Text = "";
            lblAddress.Text ="";
            lblPhone.Text = "";
            lblDateOfBirth.Text = "";
            lblGendor.Text = "";
            lblCountry.Text = "";
            _LoadPersonImage();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPerson frm = new AddPerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
