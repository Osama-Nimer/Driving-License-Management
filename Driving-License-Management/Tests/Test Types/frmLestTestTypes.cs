using BuisnessLayer;
using Driving_License_Management.Tests.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Tests
{
    public partial class frmLestTestTypes : Form
    {
        private DataTable dt;
        public frmLestTestTypes()
        {
            InitializeComponent();
        }

        private void frmLestTestTypes_Load(object sender, EventArgs e)
        {
            dt = TestTyps.GetAllTestTypes();
            dgvTestTypes.DataSource = dt;
            lbRecords.Text = dgvTestTypes.Rows.Count.ToString();
            if(dgvTestTypes.Rows.Count>0){

            dgvTestTypes.Columns[0].HeaderText = "ID";
            dgvTestTypes.Columns[0].Width = 120;

            dgvTestTypes.Columns[1].HeaderText = "Title";
            dgvTestTypes.Columns[1].Width = 200;

            dgvTestTypes.Columns[2].HeaderText = "Description";
            dgvTestTypes.Columns[2].Width = 400;

            dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;
}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditLestTestTypes frm = new frmEditLestTestTypes((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
