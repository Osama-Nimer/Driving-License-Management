namespace Driving_License_Management.People
{
    partial class frmFindPerson
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
            ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ctrlPersonInfoWithFilter1
            // 
            ctrlPersonInfoWithFilter1.AutoSize = true;
            ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(0, 31);
            ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1004, 519);
            ctrlPersonInfoWithFilter1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label1.Location = new System.Drawing.Point(381, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 41);
            label1.TabIndex = 1;
            label1.Text = "Find Person";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(858, 549);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 49);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1036, 601);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ctrlPersonInfoWithFilter1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "frmFindPerson";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmFindPerson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DVLD.People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}