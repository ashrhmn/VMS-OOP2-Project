using System;
using System.Drawing;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;
using VMS.Views.GeneralPublic;

namespace VMS.Views.DistrictManager
{
    public partial class DistrictManagerDashboard : Form
    {
        private readonly string _username;

        private Form _activeForm;
        public DistrictManagerDashboard(string username)
        {
            InitializeComponent();
            _username = username;
            ActivateLandingPage();
        }

        void ActivateLandingPage()
        {
            ActivatePanel(new GeneralPublicDashboard(_username));

            buttonViewResult.BackColor = Color.LightGray;
            buttonGoToPersonalProfile.BackColor = Color.Azure;
            buttonManageCandidate.BackColor = Color.LightGray;
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
            panelView.Controls.Add(formToActivate);
            panelView.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }


        private void buttonViewResult_Click(object sender, EventArgs e)
        {
            ActivatePanel(new VoteResult());

            buttonViewResult.BackColor = Color.Azure;
            buttonGoToPersonalProfile.BackColor = Color.LightGray;
            buttonManageCandidate.BackColor = Color.LightGray;

        }

        private void buttonGoToPersonalProfile_Click(object sender, EventArgs e)
        {
            ActivateLandingPage();
        }

        private void buttonManageCandidate_Click(object sender, EventArgs e)
        {
            ActivatePanel(new ManageCandidate(_username));

            buttonViewResult.BackColor = Color.LightGray;
            buttonGoToPersonalProfile.BackColor = Color.LightGray;
            buttonManageCandidate.BackColor = Color.Azure;
        }
    }
}
