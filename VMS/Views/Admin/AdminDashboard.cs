using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VMS.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        private Form _activeForm;

        public AdminDashboard()
        {
            InitializeComponent();
            ActivateLandingPage();
        }

        void ActivateLandingPage()
        {
            ActivatePanel(new AdminPanel());
            buttonAdminPanel.BackColor = Color.Azure;
            buttonViewResult.BackColor = Color.LightGray;
        }

        void ActivatePanel(Form formToActivate)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = formToActivate;
            formToActivate.TopLevel = false;
            formToActivate.FormBorderStyle = FormBorderStyle.None;
            formToActivate.Dock = DockStyle.Fill;
            panelMainView.Controls.Add(formToActivate);
            panelMainView.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            ActivateLandingPage();
        }

        private void buttonViewResult_Click(object sender, EventArgs e)
        {
            ActivatePanel(new VoteResult());
            buttonAdminPanel.BackColor = Color.LightGray;
            buttonViewResult.BackColor = Color.Azure;
        }
    }
}
