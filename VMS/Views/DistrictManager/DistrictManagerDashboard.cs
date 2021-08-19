using System;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;
using VMS.Views.GeneralPublic;

namespace VMS.Views.DistrictManager
{
    public partial class DistrictManagerDashboard : Form
    {
        //private readonly UserDetailRepo _udr;
        //private readonly CandidateRepo _cr;
        private readonly string _username;

        private Form _activeForm;
        //private Panel mainPanel;
        public DistrictManagerDashboard(string username)
        {
            InitializeComponent();
            _username = username;
            ActivatePanel(new GeneralPublicDashboard(_username));
            //_udr = new UserDetailRepo();
            //_cr = new CandidateRepo();

            //this.mainPanel = panelView;

            //RefreshTable();

            //buttonRemoveCandidate.Enabled = false;
            //buttonAddCandidate.Enabled = false;
        }

        //void RefreshTable()
        //{
        //    dataGridViewPublic.DataSource = _cr.GetCandidateDataTable();
        //    dataGridViewPublic.Columns[1].HeaderText = @"Candidate";
        //}

        //void UpdateFields(UserDetail userDetail)
        //{
        //    if (userDetail != null)
        //    {
        //        textBoxName.Text = userDetail.Name;
        //        textBoxFatherName.Text = userDetail.FatherName;
        //        textBoxMotherName.Text = userDetail.MotherName;
        //        textBoxGender.Text = userDetail.Gender;
        //        textBoxDateOfBirth.Text = userDetail.DateOfBirth.ToString("d");
        //        textBoxAddress.Text = userDetail.Address;
        //        textBoxNid.Text = userDetail.Nid;
        //    }
        //    else
        //    {
        //        textBoxName.Text = "";
        //        textBoxFatherName.Text = "";
        //        textBoxMotherName.Text = "";
        //        textBoxGender.Text = "";
        //        textBoxDateOfBirth.Text = "";
        //        textBoxAddress.Text = "";
        //        textBoxNid.Text = "";
        //    }
        //}

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

        private void dataGridViewPublic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewPublic.SelectedRows[0].Cells[1].Value.ToString() == "Yes")
            //{
            //    buttonRemoveCandidate.Enabled = true;
            //    buttonAddCandidate.Enabled = false;
            //}
            //else
            //{
            //    buttonRemoveCandidate.Enabled = false;
            //    buttonAddCandidate.Enabled = true;
            //}

            //UpdateFields(_udr.GetUserDetail((dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString())));

        }

        private void buttonAddCandidate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_cr.SetUserAsCandidate(dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString())
            //    ? @"User successfully set as Election Candidate"
            //    : @"Operation Failed");
            //RefreshTable();
        }

        private void buttonRemoveCandidate_Click(object sender, EventArgs e)
        {
            //if (_cr.RemoveUserFromCandidate(dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString()))
            //{
            //    MessageBox.Show(@"User successfully removed from Election Candidate");
            //}
            //else
            //{
            //    MessageBox.Show(@"Operation Failed");
            //}
            //RefreshTable();
        }

        private void buttonViewResult_Click(object sender, EventArgs e)
        {
            //new VoteResult().Show();
            ActivatePanel(new VoteResult());
        }

        private void buttonGoToPersonalProfile_Click(object sender, EventArgs e)
        {
            //new GeneralPublicDashboard(_username).Show();
            ActivatePanel(new GeneralPublicDashboard(_username));
        }

        private void buttonManageCandidate_Click(object sender, EventArgs e)
        {
            ActivatePanel(new ManageCandidate(_username));
        }
    }
}
