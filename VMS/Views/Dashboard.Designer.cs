
namespace VMS.Views
{
    partial class Dashboard
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
            this.userInfo = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dashboardViewPanel = new System.Windows.Forms.Panel();
            this.userRoleInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInfo.Location = new System.Drawing.Point(500, 14);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(182, 25);
            this.userInfo.TabIndex = 0;
            this.userInfo.Text = "Welcome, username";
            this.userInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(723, 18);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dashboardViewPanel
            // 
            this.dashboardViewPanel.Location = new System.Drawing.Point(12, 46);
            this.dashboardViewPanel.Name = "dashboardViewPanel";
            this.dashboardViewPanel.Size = new System.Drawing.Size(776, 392);
            this.dashboardViewPanel.TabIndex = 2;
            // 
            // userRoleInfo
            // 
            this.userRoleInfo.AutoSize = true;
            this.userRoleInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRoleInfo.Location = new System.Drawing.Point(260, 14);
            this.userRoleInfo.Name = "userRoleInfo";
            this.userRoleInfo.Size = new System.Drawing.Size(197, 25);
            this.userRoleInfo.TabIndex = 3;
            this.userRoleInfo.Text = "User Role : typeOfRole";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userRoleInfo);
            this.Controls.Add(this.dashboardViewPanel);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.userInfo);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel dashboardViewPanel;
        private System.Windows.Forms.Label userRoleInfo;
    }
}