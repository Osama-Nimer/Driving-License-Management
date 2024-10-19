using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.People
{
    public partial class frmFindPerson : Form
    {


        public delegate void DataBackHandler(object sender, int PersonID);

        public event DataBackHandler DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, ctrlPersonInfoWithFilter1.PersonID);
            this.Close();
        }
    }
}
