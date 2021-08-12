
namespace VMS.Views.DistrictManager
{
    partial class DistrictManagerDashboard
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
            this.dataGridViewPublic = new System.Windows.Forms.DataGridView();
            this.buttonRemoveCandidate = new System.Windows.Forms.Button();
            this.buttonAddCandidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMotherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNid = new System.Windows.Forms.TextBox();
            this.buttonViewResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPublic
            // 
            this.dataGridViewPublic.AllowUserToAddRows = false;
            this.dataGridViewPublic.AllowUserToDeleteRows = false;
            this.dataGridViewPublic.AllowUserToResizeRows = false;
            this.dataGridViewPublic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublic.Location = new System.Drawing.Point(22, 40);
            this.dataGridViewPublic.MultiSelect = false;
            this.dataGridViewPublic.Name = "dataGridViewPublic";
            this.dataGridViewPublic.ReadOnly = true;
            this.dataGridViewPublic.RowHeadersVisible = false;
            this.dataGridViewPublic.RowTemplate.Height = 25;
            this.dataGridViewPublic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPublic.Size = new System.Drawing.Size(285, 294);
            this.dataGridViewPublic.TabIndex = 0;
            this.dataGridViewPublic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPublic_CellClick);
            // 
            // buttonRemoveCandidate
            // 
            this.buttonRemoveCandidate.Location = new System.Drawing.Point(22, 350);
            this.buttonRemoveCandidate.Name = "buttonRemoveCandidate";
            this.buttonRemoveCandidate.Size = new System.Drawing.Size(119, 23);
            this.buttonRemoveCandidate.TabIndex = 1;
            this.buttonRemoveCandidate.Text = "Remove Candidate";
            this.buttonRemoveCandidate.UseVisualStyleBackColor = true;
            this.buttonRemoveCandidate.Click += new System.EventHandler(this.buttonRemoveCandidate_Click);
            // 
            // buttonAddCandidate
            // 
            this.buttonAddCandidate.Location = new System.Drawing.Point(216, 349);
            this.buttonAddCandidate.Name = "buttonAddCandidate";
            this.buttonAddCandidate.Size = new System.Drawing.Size(91, 23);
            this.buttonAddCandidate.TabIndex = 1;
            this.buttonAddCandidate.Text = "Set Candidate";
            this.buttonAddCandidate.UseVisualStyleBackColor = true;
            this.buttonAddCandidate.Click += new System.EventHandler(this.buttonAddCandidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(482, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Text = "Value";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father\'s Name :";
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Location = new System.Drawing.Point(482, 108);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(260, 23);
            this.textBoxFatherName.TabIndex = 3;
            this.textBoxFatherName.Text = "Value";
            this.textBoxFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mother\'s Name :";
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.Location = new System.Drawing.Point(482, 137);
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(260, 23);
            this.textBoxMotherName.TabIndex = 3;
            this.textBoxMotherName.Text = "Value";
            this.textBoxMotherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender :";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(482, 166);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(260, 23);
            this.textBoxGender.TabIndex = 3;
            this.textBoxGender.Text = "Value";
            this.textBoxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Of Birth :";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(482, 195);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(260, 23);
            this.textBoxDateOfBirth.TabIndex = 3;
            this.textBoxDateOfBirth.Text = "Value";
            this.textBoxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(482, 224);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(260, 23);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.Text = "Value";
            this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "NID :";
            // 
            // textBoxNid
            // 
            this.textBoxNid.Location = new System.Drawing.Point(482, 253);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(260, 23);
            this.textBoxNid.TabIndex = 3;
            this.textBoxNid.Text = "Value";
            this.textBoxNid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonViewResult
            // 
            this.buttonViewResult.Location = new System.Drawing.Point(688, 349);
            this.buttonViewResult.Name = "buttonViewResult";
            this.buttonViewResult.Size = new System.Drawing.Size(75, 23);
            this.buttonViewResult.TabIndex = 4;
            this.buttonViewResult.Text = "View Result";
            this.buttonViewResult.UseVisualStyleBackColor = true;
            this.buttonViewResult.Click += new System.EventHandler(this.buttonViewResult_Click);
            // 
            // DistrictManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.buttonViewResult);
            this.Controls.Add(this.textBoxNid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMotherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCandidate);
            this.Controls.Add(this.buttonRemoveCandidate);
            this.Controls.Add(this.dataGridViewPublic);
            this.Name = "DistrictManagerDashboard";
            this.Text = "DistrictManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPublic;
        private System.Windows.Forms.Button buttonRemoveCandidate;
        private System.Windows.Forms.Button buttonAddCandidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMotherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNid;
        private System.Windows.Forms.Button buttonViewResult;
    }
}