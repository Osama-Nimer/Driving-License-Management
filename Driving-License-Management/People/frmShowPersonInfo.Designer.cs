namespace Driving_License_Management.People
{
    partial class frmShowPersonInfo
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
            label1 = new System.Windows.Forms.Label();
            ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label1.Location = new System.Drawing.Point(437, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 41);
            label1.TabIndex = 2;
            label1.Text = "Find Person";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new System.Drawing.Point(35, 54);
            ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new System.Drawing.Size(989, 338);
            ctrlPersonCard1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(877, 399);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 49);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 457);
            Controls.Add(button1);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(label1);
            Name = "frmShowPersonInfo";
            Text = "frmShowPersonInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DVLD.People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button button1;
    }
}