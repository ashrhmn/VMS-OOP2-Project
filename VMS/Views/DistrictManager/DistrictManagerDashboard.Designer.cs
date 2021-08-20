
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
            this.buttonViewResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewResult.Location = new System.Drawing.Point(8, 31);
            this.buttonViewResult.Name = "buttonViewResult";
            this.buttonViewResult.Size = new System.Drawing.Size(120, 77);
            this.buttonViewResult.TabIndex = 4;
            this.buttonViewResult.Text = "View Result";
            this.buttonViewResult.UseVisualStyleBackColor = true;
            this.buttonViewResult.Click += new System.EventHandler(this.buttonViewResult_Click);
            // 
            // buttonGoToPersonalProfile
            // 
            this.buttonGoToPersonalProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToPersonalProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoToPersonalProfile.Location = new System.Drawing.Point(6, 38);
            this.buttonGoToPersonalProfile.Name = "buttonGoToPersonalProfile";
            this.buttonGoToPersonalProfile.Size = new System.Drawing.Size(120, 69);
            this.buttonGoToPersonalProfile.TabIndex = 5;
            this.buttonGoToPersonalProfile.Text = "Personal Profile";
            this.buttonGoToPersonalProfile.UseVisualStyleBackColor = true;
            this.buttonGoToPersonalProfile.Click += new System.EventHandler(this.buttonGoToPersonalProfile_Click);
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(133, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(866, 432);
            this.panelView.TabIndex = 6;
            // 
            // buttonManageCandidate
            // 
            this.buttonManageCandidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManageCandidate.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageCandidate.Location = new System.Drawing.Point(6, 9);
            this.buttonManageCandidate.Name = "buttonManageCandidate";
            this.buttonManageCandidate.Size = new System.Drawing.Size(120, 96);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 432);
            this.panel1.TabIndex = 8;
            // 
            // panelManageCandidateBtn
            // 
            this.panelManageCandidateBtn.Controls.Add(this.buttonManageCandidate);
            this.panelManageCandidateBtn.Location = new System.Drawing.Point(0, 3);
            this.panelManageCandidateBtn.Name = "panelManageCandidateBtn";
            this.panelManageCandidateBtn.Size = new System.Drawing.Size(136, 142);
            this.panelManageCandidateBtn.TabIndex = 10;
            // 
            // panelViewResultBtn
            // 
            this.panelViewResultBtn.Controls.Add(this.buttonViewResult);
            this.panelViewResultBtn.Location = new System.Drawing.Point(0, 145);
            this.panelViewResultBtn.Name = "panelViewResultBtn";
            this.panelViewResultBtn.Size = new System.Drawing.Size(136, 138);
            this.panelViewResultBtn.TabIndex = 9;
            // 
            // panelPersonalProfileBtn
            // 
            this.panelPersonalProfileBtn.Controls.Add(this.buttonGoToPersonalProfile);
            this.panelPersonalProfileBtn.Location = new System.Drawing.Point(0, 281);
            this.panelPersonalProfileBtn.Name = "panelPersonalProfileBtn";
            this.panelPersonalProfileBtn.Size = new System.Drawing.Size(136, 151);
            this.panelPersonalProfileBtn.TabIndex = 8;
            // 
            // DistrictManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelView);
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