namespace Driving_License_Management.Users
{
    partial class frmAddUpdateUser
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
            lbTitle = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tpPersonInfo = new System.Windows.Forms.TabPage();
            button1 = new System.Windows.Forms.Button();
            ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            tpLogin = new System.Windows.Forms.TabPage();
            chkIsActive = new System.Windows.Forms.CheckBox();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            lbUserID = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tabControl1.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            tpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbTitle.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            lbTitle.Location = new System.Drawing.Point(377, 27);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(322, 41);
            lbTitle.TabIndex = 19;
            lbTitle.Text = "Edit Application Type";
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(924, 646);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(141, 47);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(762, 646);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(141, 47);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPersonInfo);
            tabControl1.Controls.Add(tpLogin);
            tabControl1.Location = new System.Drawing.Point(15, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1050, 554);
            tabControl1.TabIndex = 16;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(button1);
            tpPersonInfo.Controls.Add(ctrlPersonInfoWithFilter1);
            tpPersonInfo.Location = new System.Drawing.Point(4, 29);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            tpPersonInfo.Size = new System.Drawing.Size(1042, 521);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "Person Info";
            tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Next_32;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.Location = new System.Drawing.Point(867, 467);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 48);
            button1.TabIndex = 1;
            button1.Text = "Next   ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            ctrlPersonInfoWithFilter1.FilterEnabled = true;
            ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(36, -15);
            ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            ctrlPersonInfoWithFilter1.ShowAddPerson = true;
            ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1000, 475);
            ctrlPersonInfoWithFilter1.TabIndex = 0;
            // 
            // tpLogin
            // 
            tpLogin.Controls.Add(chkIsActive);
            tpLogin.Controls.Add(txtConfirmPassword);
            tpLogin.Controls.Add(txtPassword);
            tpLogin.Controls.Add(txtUserName);
            tpLogin.Controls.Add(lbUserID);
            tpLogin.Controls.Add(pictureBox3);
            tpLogin.Controls.Add(pictureBox5);
            tpLogin.Controls.Add(label4);
            tpLogin.Controls.Add(label3);
            tpLogin.Controls.Add(pictureBox2);
            tpLogin.Controls.Add(label2);
            tpLogin.Controls.Add(pictureBox1);
            tpLogin.Controls.Add(label1);
            tpLogin.Location = new System.Drawing.Point(4, 29);
            tpLogin.Name = "tpLogin";
            tpLogin.Padding = new System.Windows.Forms.Padding(3);
            tpLogin.Size = new System.Drawing.Size(1042, 521);
            tpLogin.TabIndex = 1;
            tpLogin.Text = "Login Info";
            tpLogin.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkIsActive.Location = new System.Drawing.Point(286, 307);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(99, 27);
            chkIsActive.TabIndex = 14;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(286, 252);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(199, 27);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(286, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(199, 27);
            txtPassword.TabIndex = 12;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(286, 153);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(199, 27);
            txtUserName.TabIndex = 11;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbUserID.Location = new System.Drawing.Point(286, 98);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new System.Drawing.Size(31, 23);
            lbUserID.TabIndex = 10;
            lbUserID.Text = "???";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new System.Drawing.Point(237, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(33, 33);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Number_32;
            pictureBox5.Location = new System.Drawing.Point(237, 200);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(33, 33);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(69, 253);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(161, 23);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(69, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 23);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new System.Drawing.Point(237, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(33, 33);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(69, 147);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new System.Drawing.Point(237, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(33, 33);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(69, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1086, 709);
            Controls.Add(lbTitle);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "frmAddUpdateUser";
            Text = "frmAddUpdateUser";
            Load += frmAddUpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            tpLogin.ResumeLayout(false);
            tpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.Button button1;
        private DVLD.People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}