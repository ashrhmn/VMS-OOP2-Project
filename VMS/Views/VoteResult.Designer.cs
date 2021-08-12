
namespace VMS.Views
{
    partial class VoteResult
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
            this.dataGridViewCandidates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCandidates
            // 
            this.dataGridViewCandidates.AllowUserToAddRows = false;
            this.dataGridViewCandidates.AllowUserToDeleteRows = false;
            this.dataGridViewCandidates.AllowUserToResizeRows = false;
            this.dataGridViewCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandidates.Location = new System.Drawing.Point(42, 58);
            this.dataGridViewCandidates.MultiSelect = false;
            this.dataGridViewCandidates.Name = "dataGridViewCandidates";
            this.dataGridViewCandidates.ReadOnly = true;
            this.dataGridViewCandidates.RowHeadersVisible = false;
            this.dataGridViewCandidates.RowTemplate.Height = 25;
            this.dataGridViewCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCandidates.Size = new System.Drawing.Size(239, 293);
            this.dataGridViewCandidates.TabIndex = 0;
            // 
            // VoteResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCandidates);
            this.Name = "VoteResult";
            this.Text = "VoteResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCandidates;
    }
}