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
    public partial class ctrlUserCard : UserControl
    {
        private User _User;
        private int _UserID;

        public int UserID { get => _UserID;}
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = User.FindUserbyUserID(UserID);
            if (_User == null) 
            {
                ReseUserInfo();
                MessageBox.Show("No User with user ID = " + UserID);
                return;
            }
            
            FillUserInfo();
        }


        private void FillUserInfo() 
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lbUserID.Text = _UserID.ToString();
            lbUsername.Text = _User.UserName.ToString();
            if (_User.IsActive)
                lbIsActive.Text = "Yes";
            else
                lbIsActive.Text = "No";
        }

        private void ReseUserInfo()
        {
            ctrlPersonCard1._ResetPersonInfp();
            lbUserID.Text = "???";
            lbUsername.Text = "???";
            lbIsActive.Text = "???";
        }
    }
}
