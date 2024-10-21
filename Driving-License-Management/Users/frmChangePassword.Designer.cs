namespace Driving_License_Management.Users
{
    partial class frmChangePassword
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
            ctrlUserCard1 = new ctrlUserCard();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtCurrentPassword = new System.Windows.Forms.TextBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new System.Drawing.Point(-22, -26);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new System.Drawing.Size(990, 482);
            ctrlUserCard1.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(255, 591);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(199, 27);
            txtConfirmPassword.TabIndex = 22;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(255, 540);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(199, 27);
            txtPassword.TabIndex = 21;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new System.Drawing.Point(255, 491);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new System.Drawing.Size(199, 27);
            txtCurrentPassword.TabIndex = 20;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new System.Drawing.Point(206, 593);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(33, 33);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Number_32;
            pictureBox5.Location = new System.Drawing.Point(206, 540);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(33, 33);
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(38, 593);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(161, 23);
            label4.TabIndex = 17;
            label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(38, 540);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(136, 23);
            label3.TabIndex = 16;
            label3.Text = "New Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(38, 487);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 23);
            label2.TabIndex = 14;
            label2.Text = "Current Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new System.Drawing.Point(206, 487);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(33, 33);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(805, 630);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(141, 47);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(643, 630);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(141, 47);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(969, 686);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ctrlUserCard1);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}