using Driving_License_Management.Properties;
using System;
using System.Data;

namespace DVLD.People
{
    partial class frmPeopleList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleList));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dgvPeople = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            showPersonDaetalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sendEamilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            txtFilterValue = new System.Windows.Forms.TextBox();
            cbFilterBy = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            lbRecords = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.People_400;
            pictureBox1.Location = new System.Drawing.Point(622, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(245, 208);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvPeople
            // 
            dgvPeople.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = contextMenuStrip1;
            dgvPeople.Location = new System.Drawing.Point(73, 378);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.Size = new System.Drawing.Size(1340, 373);
            dgvPeople.TabIndex = 10;
            dgvPeople.DoubleClick += dgvPeople_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showPersonDaetalesToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, sendEamilToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(263, 232);
            // 
            // showPersonDaetalesToolStripMenuItem
            // 
            showPersonDaetalesToolStripMenuItem.Image = Resources.PersonDetails_32;
            showPersonDaetalesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            showPersonDaetalesToolStripMenuItem.Name = "showPersonDaetalesToolStripMenuItem";
            showPersonDaetalesToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            showPersonDaetalesToolStripMenuItem.Text = "Show person Details";
            showPersonDaetalesToolStripMenuItem.Click += showPersonDaetalesToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Resources.AddPerson_32;
            addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Resources.edit_32;
            editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sendEamilToolStripMenuItem
            // 
            sendEamilToolStripMenuItem.Image = Resources.send_email_32;
            sendEamilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            sendEamilToolStripMenuItem.Name = "sendEamilToolStripMenuItem";
            sendEamilToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            sendEamilToolStripMenuItem.Text = "Send Eamil";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Resources.call_32;
            phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new System.Drawing.Point(470, 305);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new System.Drawing.Size(247, 27);
            txtFilterValue.TabIndex = 9;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "CountryName", "GendorCaption", "Phone", "Email", "None" });
            cbFilterBy.Location = new System.Drawing.Point(196, 305);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new System.Drawing.Size(244, 28);
            cbFilterBy.TabIndex = 8;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(73, 304);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 25);
            label2.TabIndex = 7;
            label2.Text = "Filtter By :";
            // 
            // lbRecords
            // 
            lbRecords.AutoSize = true;
            lbRecords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbRecords.Location = new System.Drawing.Point(73, 766);
            lbRecords.Name = "lbRecords";
            lbRecords.Size = new System.Drawing.Size(120, 25);
            lbRecords.TabIndex = 11;
            lbRecords.Text = "#Records ???";
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Resources.Close_32;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(1272, 757);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(141, 47);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(1343, 287);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(70, 63);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPeopleList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1458, 814);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(lbRecords);
            Controls.Add(dgvPeople);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "frmPeopleList";
            Text = " ";
            Load += frmPeopleList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDaetalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEamilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}