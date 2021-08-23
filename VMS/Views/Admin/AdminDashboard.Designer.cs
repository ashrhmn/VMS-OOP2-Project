
namespace VMS.Views.Admin
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSignUpView = new System.Windows.Forms.Button();
            this.buttonViewResult = new System.Windows.Forms.Button();
            this.buttonAdminPanel = new System.Windows.Forms.Button();
            this.panelMainView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSignUpView);
            this.panel1.Controls.Add(this.buttonViewResult);
            this.panel1.Controls.Add(this.buttonAdminPanel);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 621);
            this.panel1.TabIndex = 0;
            // 
            // buttonSignUpView
            // 
            this.buttonSignUpView.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSignUpView.Location = new System.Drawing.Point(9, 275);
            this.buttonSignUpView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSignUpView.Name = "buttonSignUpView";
            this.buttonSignUpView.Size = new System.Drawing.Size(167, 89);
            this.buttonSignUpView.TabIndex = 1;
            this.buttonSignUpView.Text = "SignUps";
            this.buttonSignUpView.UseVisualStyleBackColor = true;
            this.buttonSignUpView.Click += new System.EventHandler(this.buttonSignUpView_Click);
            // 
            // buttonViewResult
            // 
            this.buttonViewResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewResult.Location = new System.Drawing.Point(10, 167);
            this.buttonViewResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewResult.Name = "buttonViewResult";
            this.buttonViewResult.Size = new System.Drawing.Size(167, 89);
            this.buttonViewResult.TabIndex = 1;
            this.buttonViewResult.Text = "View Result";
            this.buttonViewResult.UseVisualStyleBackColor = true;
            this.buttonViewResult.Click += new System.EventHandler(this.buttonViewResult_Click);
            // 
            // buttonAdminPanel
            // 
            this.buttonAdminPanel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdminPanel.Location = new System.Drawing.Point(10, 44);
            this.buttonAdminPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdminPanel.Name = "buttonAdminPanel";
            this.buttonAdminPanel.Size = new System.Drawing.Size(167, 103);
            this.buttonAdminPanel.TabIndex = 0;
            this.buttonAdminPanel.Text = "Admin";
            this.buttonAdminPanel.UseVisualStyleBackColor = true;
            this.buttonAdminPanel.Click += new System.EventHandler(this.buttonAdminPanel_Click);
            // 
            // panelMainView
            // 
            this.panelMainView.Location = new System.Drawing.Point(187, 4);
            this.panelMainView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMainView.Name = "panelMainView";
            this.panelMainView.Size = new System.Drawing.Size(983, 621);
            this.panelMainView.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 624);
            this.Controls.Add(this.panelMainView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminDashboard";
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMainView;
        private System.Windows.Forms.Button buttonViewResult;
        private System.Windows.Forms.Button buttonAdminPanel;
        private System.Windows.Forms.Button buttonSignUpView;
    }
}