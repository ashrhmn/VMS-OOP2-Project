using System;
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
            ActivatePanel(new GeneralPublicDashboard(_username));
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
        }

        private void buttonGoToPersonalProfile_Click(object sender, EventArgs e)
        {
            ActivatePanel(new GeneralPublicDashboard(_username));
        }

        private void buttonManageCandidate_Click(object sender, EventArgs e)
        {
            ActivatePanel(new ManageCandidate(_username));
        }
    }
}
