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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleList));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtFilterValue = new System.Windows.Forms.TextBox();
            cbFilterBy = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            lbRecords = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(92, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1340, 373);
            dataGridView1.TabIndex = 10;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new System.Drawing.Point(490, 305);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new System.Drawing.Size(247, 27);
            txtFilterValue.TabIndex = 9;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new System.Drawing.Point(224, 305);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new System.Drawing.Size(244, 28);
            cbFilterBy.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(92, 304);
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
            lbRecords.Location = new System.Drawing.Point(92, 757);
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
            btnClose.Location = new System.Drawing.Point(1291, 757);
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
            button1.Location = new System.Drawing.Point(1362, 287);
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
            Controls.Add(dataGridView1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "frmPeopleList";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}