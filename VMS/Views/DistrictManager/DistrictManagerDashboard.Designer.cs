
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPublic
            // 
            this.dataGridViewPublic.AllowUserToAddRows = false;
            this.dataGridViewPublic.AllowUserToDeleteRows = false;
            this.dataGridViewPublic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublic.Location = new System.Drawing.Point(22, 40);
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
            // DistrictManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.buttonAddCandidate);
            this.Controls.Add(this.buttonRemoveCandidate);
            this.Controls.Add(this.dataGridViewPublic);
            this.Name = "DistrictManagerDashboard";
            this.Text = "DistrictManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPublic;
        private System.Windows.Forms.Button buttonRemoveCandidate;
        private System.Windows.Forms.Button buttonAddCandidate;
    }
}