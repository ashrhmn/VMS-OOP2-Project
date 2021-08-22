
namespace VMS.Views.DistrictManager
{
    partial class ManageCandidate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelView = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveCandidate = new System.Windows.Forms.Button();
            this.buttonAddCandidate = new System.Windows.Forms.Button();
            this.textBoxNid = new System.Windows.Forms.TextBox();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.dataGridViewPublic = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxMotherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.textBoxName);
            this.panelView.Controls.Add(this.label1);
            this.panelView.Controls.Add(this.label2);
            this.panelView.Controls.Add(this.buttonRemoveCandidate);
            this.panelView.Controls.Add(this.buttonAddCandidate);
            this.panelView.Controls.Add(this.textBoxNid);
            this.panelView.Controls.Add(this.textBoxFatherName);
            this.panelView.Controls.Add(this.dataGridViewPublic);
            this.panelView.Controls.Add(this.label7);
            this.panelView.Controls.Add(this.label3);
            this.panelView.Controls.Add(this.textBoxAddress);
            this.panelView.Controls.Add(this.textBoxMotherName);
            this.panelView.Controls.Add(this.label6);
            this.panelView.Controls.Add(this.label4);
            this.panelView.Controls.Add(this.textBoxDateOfBirth);
            this.panelView.Controls.Add(this.textBoxGender);
            this.panelView.Controls.Add(this.label5);
            this.panelView.Location = new System.Drawing.Point(2, 3);
            this.panelView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(958, 523);
            this.panelView.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(610, 130);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(297, 32);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(525, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(456, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father\'s Name :";
            // 
            // buttonRemoveCandidate
            // 
            this.buttonRemoveCandidate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCandidate.Location = new System.Drawing.Point(32, 464);
            this.buttonRemoveCandidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveCandidate.Name = "buttonRemoveCandidate";
            this.buttonRemoveCandidate.Size = new System.Drawing.Size(119, 36);
            this.buttonRemoveCandidate.TabIndex = 1;
            this.buttonRemoveCandidate.Text = "Remove Candidate";
            this.buttonRemoveCandidate.UseVisualStyleBackColor = true;
            this.buttonRemoveCandidate.Click += new System.EventHandler(this.buttonRemoveCandidate_Click);
            // 
            // buttonAddCandidate
            // 
            this.buttonAddCandidate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCandidate.Location = new System.Drawing.Point(299, 464);
            this.buttonAddCandidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddCandidate.Name = "buttonAddCandidate";
            this.buttonAddCandidate.Size = new System.Drawing.Size(108, 36);
            this.buttonAddCandidate.TabIndex = 1;
            this.buttonAddCandidate.Text = "Set Candidate";
            this.buttonAddCandidate.UseVisualStyleBackColor = true;
            this.buttonAddCandidate.Click += new System.EventHandler(this.buttonAddCandidate_Click);
            // 
            // textBoxNid
            // 
            this.textBoxNid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNid.Location = new System.Drawing.Point(610, 362);
            this.textBoxNid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(297, 32);
            this.textBoxNid.TabIndex = 3;
            this.textBoxNid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFatherName.Location = new System.Drawing.Point(610, 169);
            this.textBoxFatherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(297, 32);
            this.textBoxFatherName.TabIndex = 3;
            this.textBoxFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewPublic
            // 
            this.dataGridViewPublic.AllowUserToAddRows = false;
            this.dataGridViewPublic.AllowUserToDeleteRows = false;
            this.dataGridViewPublic.AllowUserToResizeRows = false;
            this.dataGridViewPublic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPublic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPublic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPublic.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPublic.Location = new System.Drawing.Point(32, 31);
            this.dataGridViewPublic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPublic.MultiSelect = false;
            this.dataGridViewPublic.Name = "dataGridViewPublic";
            this.dataGridViewPublic.ReadOnly = true;
            this.dataGridViewPublic.RowHeadersVisible = false;
            this.dataGridViewPublic.RowHeadersWidth = 51;
            this.dataGridViewPublic.RowTemplate.Height = 25;
            this.dataGridViewPublic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPublic.Size = new System.Drawing.Size(375, 411);
            this.dataGridViewPublic.TabIndex = 0;
            this.dataGridViewPublic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPublic_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(543, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "NID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(446, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mother\'s Name :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(610, 324);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(297, 32);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMotherName.Location = new System.Drawing.Point(610, 208);
            this.textBoxMotherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(297, 32);
            this.textBoxMotherName.TabIndex = 3;
            this.textBoxMotherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(508, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(513, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender :";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(610, 285);
            this.textBoxDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(297, 32);
            this.textBoxDateOfBirth.TabIndex = 3;
            this.textBoxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGender.Location = new System.Drawing.Point(610, 246);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(297, 32);
            this.textBoxGender.TabIndex = 3;
            this.textBoxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(466, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Of Birth :";
            // 
            // ManageCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 528);
            this.Controls.Add(this.panelView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageCandidate";
            this.Text = "ManageCandidate";
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveCandidate;
        private System.Windows.Forms.Button buttonAddCandidate;
        private System.Windows.Forms.TextBox textBoxNid;
        private System.Windows.Forms.TextBox textBoxFatherName;
        private System.Windows.Forms.DataGridView dataGridViewPublic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxMotherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label5;
    }
}