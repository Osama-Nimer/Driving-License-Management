namespace Driving_License_Management.Users
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lbUserID = new System.Windows.Forms.Label();
            lbUsername = new System.Windows.Forms.Label();
            lbIsActive = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new System.Drawing.Point(13, 10);
            ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new System.Drawing.Size(968, 401);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbIsActive);
            groupBox1.Controls.Add(lbUsername);
            groupBox1.Controls.Add(lbUserID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(36, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(936, 63);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(125, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(378, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(627, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Is Active :";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new System.Drawing.Point(200, 23);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new System.Drawing.Size(30, 20);
            lbUserID.TabIndex = 3;
            lbUserID.Text = "???";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new System.Drawing.Point(472, 23);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(30, 20);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "???";
            // 
            // lbIsActive
            // 
            lbIsActive.AutoSize = true;
            lbIsActive.Location = new System.Drawing.Point(710, 23);
            lbIsActive.Name = "lbIsActive";
            lbIsActive.Size = new System.Drawing.Size(30, 20);
            lbIsActive.TabIndex = 5;
            lbIsActive.Text = "???";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new System.Drawing.Size(996, 491);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DVLD.People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUserID;
    }
}
