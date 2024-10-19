using Driving_License_Management.Properties;

namespace DVLD.People.Controls
{
    partial class ctrlPersonInfoWithFilter
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
            components = new System.ComponentModel.Container();
            gbFilters = new System.Windows.Forms.GroupBox();
            btnAddNewPerson = new System.Windows.Forms.Button();
            btnFind = new System.Windows.Forms.Button();
            cbFilterBy = new System.Windows.Forms.ComboBox();
            txtFilterValue = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ctrlPersonCard1 = new ctrlPersonCard();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Location = new System.Drawing.Point(41, 42);
            gbFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbFilters.Size = new System.Drawing.Size(940, 96);
            gbFilters.TabIndex = 17;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddNewPerson.Image = Resources.AddPerson_32;
            btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddNewPerson.Location = new System.Drawing.Point(679, 25);
            btnAddNewPerson.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new System.Drawing.Size(50, 46);
            btnAddNewPerson.TabIndex = 20;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnFind
            // 
            btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFind.Image = Resources.SearchPerson;
            btnFind.Location = new System.Drawing.Point(621, 25);
            btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(50, 46);
            btnFind.TabIndex = 18;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "National No.", "Person ID" });
            cbFilterBy.Location = new System.Drawing.Point(110, 31);
            cbFilterBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new System.Drawing.Size(239, 28);
            cbFilterBy.TabIndex = 16;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFilterValue.Location = new System.Drawing.Point(358, 31);
            txtFilterValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new System.Drawing.Size(244, 27);
            txtFilterValue.TabIndex = 17;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(18, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 25);
            label1.TabIndex = 19;
            label1.Text = "Find By:";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new System.Drawing.Point(19, 123);
            ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new System.Drawing.Size(992, 344);
            ctrlPersonCard1.TabIndex = 18;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonInfoWithFilter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ctrlPersonCard1);
            Controls.Add(gbFilters);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ctrlPersonInfoWithFilter";
            Size = new System.Drawing.Size(1058, 541);
            Load += ctrlPersonInfoWithFilter_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
