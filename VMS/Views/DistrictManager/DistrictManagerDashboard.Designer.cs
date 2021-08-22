
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
            this.buttonViewResult = new System.Windows.Forms.Button();
            this.buttonGoToPersonalProfile = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.buttonManageCandidate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelManageCandidateBtn = new System.Windows.Forms.Panel();
            this.panelViewResultBtn = new System.Windows.Forms.Panel();
            this.panelPersonalProfileBtn = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelManageCandidateBtn.SuspendLayout();
            this.panelViewResultBtn.SuspendLayout();
            this.panelPersonalProfileBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewResult
            // 
            this.buttonViewResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewResult.Location = new System.Drawing.Point(9, 19);
            this.buttonViewResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewResult.Name = "buttonViewResult";
            this.buttonViewResult.Size = new System.Drawing.Size(137, 103);
            this.buttonViewResult.TabIndex = 4;
            this.buttonViewResult.Text = "View Result";
            this.buttonViewResult.UseVisualStyleBackColor = true;
            this.buttonViewResult.Click += new System.EventHandler(this.buttonViewResult_Click);
            // 
            // buttonGoToPersonalProfile
            // 
            this.buttonGoToPersonalProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToPersonalProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoToPersonalProfile.Location = new System.Drawing.Point(9, 21);
            this.buttonGoToPersonalProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGoToPersonalProfile.Name = "buttonGoToPersonalProfile";
            this.buttonGoToPersonalProfile.Size = new System.Drawing.Size(137, 92);
            this.buttonGoToPersonalProfile.TabIndex = 5;
            this.buttonGoToPersonalProfile.Text = "Personal Profile";
            this.buttonGoToPersonalProfile.UseVisualStyleBackColor = true;
            this.buttonGoToPersonalProfile.Click += new System.EventHandler(this.buttonGoToPersonalProfile_Click);
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(152, 0);
            this.panelView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(990, 576);
            this.panelView.TabIndex = 6;
            // 
            // buttonManageCandidate
            // 
            this.buttonManageCandidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManageCandidate.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageCandidate.Location = new System.Drawing.Point(7, 12);
            this.buttonManageCandidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonManageCandidate.Name = "buttonManageCandidate";
            this.buttonManageCandidate.Size = new System.Drawing.Size(137, 128);
            this.buttonManageCandidate.TabIndex = 7;
            this.buttonManageCandidate.Text = "Manage Candidate";
            this.buttonManageCandidate.UseVisualStyleBackColor = true;
            this.buttonManageCandidate.Click += new System.EventHandler(this.buttonManageCandidate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelManageCandidateBtn);
            this.panel1.Controls.Add(this.panelViewResultBtn);
            this.panel1.Controls.Add(this.panelPersonalProfileBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 576);
            this.panel1.TabIndex = 8;
            // 
            // panelManageCandidateBtn
            // 
            this.panelManageCandidateBtn.Controls.Add(this.buttonManageCandidate);
            this.panelManageCandidateBtn.Location = new System.Drawing.Point(0, 4);
            this.panelManageCandidateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelManageCandidateBtn.Name = "panelManageCandidateBtn";
            this.panelManageCandidateBtn.Size = new System.Drawing.Size(155, 189);
            this.panelManageCandidateBtn.TabIndex = 10;
            // 
            // panelViewResultBtn
            // 
            this.panelViewResultBtn.Controls.Add(this.buttonViewResult);
            this.panelViewResultBtn.Location = new System.Drawing.Point(0, 193);
            this.panelViewResultBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelViewResultBtn.Name = "panelViewResultBtn";
            this.panelViewResultBtn.Size = new System.Drawing.Size(155, 184);
            this.panelViewResultBtn.TabIndex = 9;
            // 
            // panelPersonalProfileBtn
            // 
            this.panelPersonalProfileBtn.Controls.Add(this.buttonGoToPersonalProfile);
            this.panelPersonalProfileBtn.Location = new System.Drawing.Point(0, 375);
            this.panelPersonalProfileBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPersonalProfileBtn.Name = "panelPersonalProfileBtn";
            this.panelPersonalProfileBtn.Size = new System.Drawing.Size(155, 201);
            this.panelPersonalProfileBtn.TabIndex = 8;
            // 
            // DistrictManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1143, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DistrictManagerDashboard";
            this.Text = "DistrictManagerDashboard";
            this.panel1.ResumeLayout(false);
            this.panelManageCandidateBtn.ResumeLayout(false);
            this.panelViewResultBtn.ResumeLayout(false);
            this.panelPersonalProfileBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonViewResult;
        private System.Windows.Forms.Button buttonGoToPersonalProfile;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button buttonManageCandidate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelManageCandidateBtn;
        private System.Windows.Forms.Panel panelViewResultBtn;
        private System.Windows.Forms.Panel panelPersonalProfileBtn;
    }
}