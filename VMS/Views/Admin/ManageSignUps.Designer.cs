
namespace VMS.Views.Admin
{
    partial class ManageSignUps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.textBoxNid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApproveSignup = new System.Windows.Forms.Button();
            this.buttonAutogen = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeRows = false;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.usersGridView.Location = new System.Drawing.Point(45, 69);
            this.usersGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidth = 51;
            this.usersGridView.RowTemplate.Height = 25;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(465, 344);
            this.usersGridView.TabIndex = 1;
            // 
            // textBoxNid
            // 
            this.textBoxNid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNid.Location = new System.Drawing.Point(598, 159);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(237, 32);
            this.textBoxNid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(541, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NID :";
            // 
            // buttonApproveSignup
            // 
            this.buttonApproveSignup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApproveSignup.Location = new System.Drawing.Point(660, 197);
            this.buttonApproveSignup.Name = "buttonApproveSignup";
            this.buttonApproveSignup.Size = new System.Drawing.Size(175, 40);
            this.buttonApproveSignup.TabIndex = 4;
            this.buttonApproveSignup.Text = "Approve Sign Up";
            this.buttonApproveSignup.UseVisualStyleBackColor = true;
            this.buttonApproveSignup.Click += new System.EventHandler(this.buttonApproveSignup_Click);
            // 
            // buttonAutogen
            // 
            this.buttonAutogen.Location = new System.Drawing.Point(841, 159);
            this.buttonAutogen.Name = "buttonAutogen";
            this.buttonAutogen.Size = new System.Drawing.Size(94, 29);
            this.buttonAutogen.TabIndex = 5;
            this.buttonAutogen.Text = "Autogen";
            this.buttonAutogen.UseVisualStyleBackColor = true;
            this.buttonAutogen.Click += new System.EventHandler(this.buttonAutogen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(567, 197);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ManageSignUps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 526);
            this.Controls.Add(this.buttonAutogen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonApproveSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNid);
            this.Controls.Add(this.usersGridView);
            this.Name = "ManageSignUps";
            this.Text = "ManageSignUps";
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.TextBox textBoxNid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApproveSignup;
        private System.Windows.Forms.Button buttonAutogen;
        private System.Windows.Forms.Button buttonDelete;
    }
}