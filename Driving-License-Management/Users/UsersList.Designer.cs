namespace Driving_License_Management.Users
{
    partial class UsersList
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
            pb = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgvUsers = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            showPersonDaetalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sendEamilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAdd = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            lbRecords = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cbFilterBy = new System.Windows.Forms.ComboBox();
            txtFilterValue = new System.Windows.Forms.TextBox();
            cbIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pb
            // 
            pb.Image = Properties.Resources.Users_2_400;
            pb.Location = new System.Drawing.Point(459, 12);
            pb.Name = "pb";
            pb.Size = new System.Drawing.Size(223, 178);
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(72, 282);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Filter By :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(72, 677);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "#Records :";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvUsers.Location = new System.Drawing.Point(72, 327);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new System.Drawing.Size(1038, 323);
            dgvUsers.TabIndex = 3;
            dgvUsers.CellContentDoubleClick += dgvUsers_CellContentDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showPersonDaetalesToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, sendEamilToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(241, 270);
            // 
            // showPersonDaetalesToolStripMenuItem
            // 
            showPersonDaetalesToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDaetalesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            showPersonDaetalesToolStripMenuItem.Name = "showPersonDaetalesToolStripMenuItem";
            showPersonDaetalesToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            showPersonDaetalesToolStripMenuItem.Text = "Show Details";
            showPersonDaetalesToolStripMenuItem.Click += showPersonDaetalesToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_New_User_32;
            addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            addNewPersonToolStripMenuItem.Text = "Add New User";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // sendEamilToolStripMenuItem
            // 
            sendEamilToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEamilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            sendEamilToolStripMenuItem.Name = "sendEamilToolStripMenuItem";
            sendEamilToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            sendEamilToolStripMenuItem.Text = "Send Eamil";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add_New_User_72;
            btnAdd.Location = new System.Drawing.Point(1018, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(92, 94);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(968, 656);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(142, 52);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbRecords
            // 
            lbRecords.AutoSize = true;
            lbRecords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbRecords.Location = new System.Drawing.Point(146, 677);
            lbRecords.Name = "lbRecords";
            lbRecords.Size = new System.Drawing.Size(30, 20);
            lbRecords.TabIndex = 6;
            lbRecords.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label3.Location = new System.Drawing.Point(459, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(245, 46);
            label3.TabIndex = 7;
            label3.Text = "Manage Users";
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User ID", "Username", "Person ID", "Full Name", "Is Active" });
            cbFilterBy.Location = new System.Drawing.Point(153, 279);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new System.Drawing.Size(214, 28);
            cbFilterBy.TabIndex = 8;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new System.Drawing.Point(387, 279);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new System.Drawing.Size(276, 27);
            txtFilterValue.TabIndex = 9;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new System.Drawing.Point(387, 278);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new System.Drawing.Size(107, 28);
            cbIsActive.TabIndex = 10;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // UsersList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1187, 723);
            Controls.Add(cbIsActive);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(lbRecords);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pb);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "UsersList";
            Text = "Manage Users";
            Load += UsersList_Load;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDaetalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEamilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbIsActive;
    }
}