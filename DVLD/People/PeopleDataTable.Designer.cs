using DVLD.Properties;

namespace DVLD.People
{
    partial class PeopleDataTable
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
            pbPersonImage = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbFilterBy = new System.Windows.Forms.ComboBox();
            txtFilterValue = new System.Windows.Forms.TextBox();
            btnAddPerson = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lbRecords = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pbPersonImage
            // 
            
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new System.Drawing.Point(739, 27);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new System.Drawing.Size(202, 190);
            pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 0;
            pbPersonImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.Red;
            lblTitle.Location = new System.Drawing.Point(765, 235);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(142, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Maneg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(62, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 25);
            label2.TabIndex = 2;
            label2.Text = "Filtter By :";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new System.Drawing.Point(194, 301);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new System.Drawing.Size(244, 28);
            cbFilterBy.TabIndex = 3;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new System.Drawing.Point(460, 301);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new System.Drawing.Size(247, 27);
            txtFilterValue.TabIndex = 4;
            // 
            // btnAddPerson
            // 
            
            btnAddPerson.Location = new System.Drawing.Point(1558, 269);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new System.Drawing.Size(59, 59);
            btnAddPerson.TabIndex = 5;
            btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(62, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1555, 373);
            dataGridView1.TabIndex = 6;
            // 
            // lbRecords
            // 
            lbRecords.AutoSize = true;
            lbRecords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbRecords.Location = new System.Drawing.Point(62, 757);
            lbRecords.Name = "lbRecords";
            lbRecords.Size = new System.Drawing.Size(120, 25);
            lbRecords.TabIndex = 7;
            lbRecords.Text = "#Records ???";
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Resources.Close_32;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(1476, 741);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(141, 38);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // PeopleDataTable
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1655, 791);
            Controls.Add(btnClose);
            Controls.Add(lbRecords);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddPerson);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(pbPersonImage);
            Name = "PeopleDataTable";
            Text = "PeopleDataTable";
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
    }
}