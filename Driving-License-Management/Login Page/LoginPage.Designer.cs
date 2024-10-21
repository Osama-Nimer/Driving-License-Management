namespace Driving_License_Management.Login_Page
{
    partial class LoginPage
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
            txtUsername = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            chkRememberMe = new System.Windows.Forms.CheckBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(1029, 251);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(249, 27);
            txtUsername.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Car;
            pictureBox1.Location = new System.Drawing.Point(-2, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(892, 771);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            label1.Location = new System.Drawing.Point(1027, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 66);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            label2.Location = new System.Drawing.Point(896, 248);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 22);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            label3.Location = new System.Drawing.Point(896, 322);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 22);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(1028, 322);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(249, 27);
            txtPassword.TabIndex = 5;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkRememberMe.Location = new System.Drawing.Point(1027, 391);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new System.Drawing.Size(133, 23);
            chkRememberMe.TabIndex = 6;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new System.Drawing.Point(990, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(33, 36);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.InitialImage = Properties.Resources.Person_32;
            pictureBox8.Location = new System.Drawing.Point(988, 248);
            pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(35, 32);
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 129;
            pictureBox8.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 64, 0);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            button1.Location = new System.Drawing.Point(1245, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(44, 38);
            button1.TabIndex = 130;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 64, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            button2.Location = new System.Drawing.Point(1028, 432);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(248, 52);
            button2.TabIndex = 131;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Forte", 13.8F);
            label4.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            label4.Location = new System.Drawing.Point(896, 694);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(218, 25);
            label4.TabIndex = 132;
            label4.Text = "Contact : 0782536729";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Forte", 13.8F);
            label5.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            label5.Location = new System.Drawing.Point(896, 659);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(146, 25);
            label5.TabIndex = 133;
            label5.Text = "Osama Nimer";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkBox2.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            checkBox2.Location = new System.Drawing.Point(1027, 362);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(139, 23);
            checkBox2.TabIndex = 134;
            checkBox2.Text = "Show Psaword";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1301, 755);
            Controls.Add(checkBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox2);
            Controls.Add(chkRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}