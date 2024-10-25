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

namespace Driving_License_Management.Tests.Test_Types
{
    public partial class frmEditLestTestTypes : Form
    {
        private int _ID = -1;
        private TestTyps test;
        public frmEditLestTestTypes(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }
    }
}
