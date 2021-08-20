
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
            this.SuspendLayout();
            // 
            // buttonViewResult
            // 
            this.buttonViewResult.Location = new System.Drawing.Point(439, 399);
            this.buttonViewResult.Name = "buttonViewResult";
            this.buttonViewResult.Size = new System.Drawing.Size(75, 23);
            this.buttonViewResult.TabIndex = 4;
            this.buttonViewResult.Text = "View Result";
            this.buttonViewResult.UseVisualStyleBackColor = true;
            this.buttonViewResult.Click += new System.EventHandler(this.buttonViewResult_Click);
            // 
            // buttonGoToPersonalProfile
            // 
            this.buttonGoToPersonalProfile.Location = new System.Drawing.Point(547, 399);
            this.buttonGoToPersonalProfile.Name = "buttonGoToPersonalProfile";
            this.buttonGoToPersonalProfile.Size = new System.Drawing.Size(97, 23);
            this.buttonGoToPersonalProfile.TabIndex = 5;
            this.buttonGoToPersonalProfile.Text = "Personal Profile";
            this.buttonGoToPersonalProfile.UseVisualStyleBackColor = true;
            this.buttonGoToPersonalProfile.Click += new System.EventHandler(this.buttonGoToPersonalProfile_Click);
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(117, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(871, 373);
            this.panelView.TabIndex = 6;
            // 
            // buttonManageCandidate
            // 
            this.buttonManageCandidate.Location = new System.Drawing.Point(285, 399);
            this.buttonManageCandidate.Name = "buttonManageCandidate";
            this.buttonManageCandidate.Size = new System.Drawing.Size(121, 23);
            this.buttonManageCandidate.TabIndex = 7;
            this.buttonManageCandidate.Text = "Manage Candidate";
            this.buttonManageCandidate.UseVisualStyleBackColor = true;
            this.buttonManageCandidate.Click += new System.EventHandler(this.buttonManageCandidate_Click);
            // 
            // DistrictManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 434);
            this.Controls.Add(this.buttonManageCandidate);
            this.Controls.Add(this.buttonGoToPersonalProfile);
            this.Controls.Add(this.buttonViewResult);
            this.Controls.Add(this.panelView);
            this.Name = "DistrictManagerDashboard";
            this.Text = "DistrictManagerDashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonViewResult;
        private System.Windows.Forms.Button buttonGoToPersonalProfile;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button buttonManageCandidate;
    }
}