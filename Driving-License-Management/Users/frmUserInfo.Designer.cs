namespace Driving_License_Management.Users
{
    partial class frmUserInfo
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
            ctrlUserCard1 = new ctrlUserCard();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new System.Drawing.Point(-24, -26);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new System.Drawing.Size(991, 496);
            ctrlUserCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(820, 455);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(130, 48);
            btnClose.TabIndex = 1;
            btnClose.Text = "     Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(965, 505);
            Controls.Add(btnClose);
            Controls.Add(ctrlUserCard1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "frmUserInfo";
            Text = "frmUserInfo";
            Load += frmUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Button btnClose;
    }
}