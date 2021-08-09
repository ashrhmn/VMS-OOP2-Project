
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
            this.dataGridViewPublic.Size = new System.Drawing.Size(285, 369);
            this.dataGridViewPublic.TabIndex = 0;
            this.dataGridViewPublic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPublic_CellClick);
            // 
            // DistrictManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPublic);
            this.Name = "DistrictManagerDashboard";
            this.Text = "DistrictManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPublic;
    }
}