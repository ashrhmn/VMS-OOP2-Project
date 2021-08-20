
namespace VMS
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainView = new System.Windows.Forms.Panel();
            this.panelTopView = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelTopView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(953, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(51, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.label1_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMainView);
            this.panelMain.Controls.Add(this.panelTopView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1031, 559);
            this.panelMain.TabIndex = 2;
            // 
            // panelMainView
            // 
            this.panelMainView.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainView.Location = new System.Drawing.Point(0, 85);
            this.panelMainView.Name = "panelMainView";
            this.panelMainView.Size = new System.Drawing.Size(1031, 474);
            this.panelMainView.TabIndex = 3;
            // 
            // panelTopView
            // 
            this.panelTopView.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTopView.Controls.Add(this.btnExit);
            this.panelTopView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopView.Location = new System.Drawing.Point(0, 0);
            this.panelTopView.Name = "panelTopView";
            this.panelTopView.Size = new System.Drawing.Size(1031, 85);
            this.panelTopView.TabIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 559);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VMS";
            this.panelMain.ResumeLayout(false);
            this.panelTopView.ResumeLayout(false);
            this.panelTopView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMainView;
        private System.Windows.Forms.Panel panelTopView;
    }
}

