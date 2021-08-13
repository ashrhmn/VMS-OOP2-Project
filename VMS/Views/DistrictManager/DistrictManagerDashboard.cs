using System;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views.DistrictManager
{
    public partial class DistrictManagerDashboard : Form
    {
        private readonly UserDetailRepo _udr;
        private readonly CandidateRepo _cr;
        public DistrictManagerDashboard()
        {
            InitializeComponent();
            _udr = new UserDetailRepo();
            _cr = new CandidateRepo();

            RefreshTable();

            buttonRemoveCandidate.Enabled = false;
            buttonAddCandidate.Enabled = false;
        }

        void RefreshTable()
        {
            dataGridViewPublic.DataSource = _cr.GetCandidateDataTable();
            dataGridViewPublic.Columns[1].HeaderText = @"Candidate";
        }

        void UpdateFields(UserDetail userDetail)
        {
            if (userDetail != null)
            {
                textBoxName.Text = userDetail.Name;
                textBoxFatherName.Text = userDetail.FatherName;
                textBoxMotherName.Text = userDetail.MotherName;
                textBoxGender.Text = userDetail.Gender;
                textBoxDateOfBirth.Text = userDetail.DateOfBirth.ToString("d");
                textBoxAddress.Text = userDetail.Address;
                textBoxNid.Text = userDetail.NID;
            }
            else
            {
                textBoxName.Text = "";
                textBoxFatherName.Text = "";
                textBoxMotherName.Text = "";
                textBoxGender.Text = "";
                textBoxDateOfBirth.Text = "";
                textBoxAddress.Text = "";
                textBoxNid.Text = "";
            }

        }

        private void dataGridViewPublic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPublic.SelectedRows[0].Cells[1].Value.ToString() == "Yes")
            {
                buttonRemoveCandidate.Enabled = true;
                buttonAddCandidate.Enabled = false;
            }
            else
            {
                buttonRemoveCandidate.Enabled = false;
                buttonAddCandidate.Enabled = true;
            }

            UpdateFields(_udr.GetUserDetail((dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString())));

        }

        private void buttonAddCandidate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cr.SetUserAsCandidate(dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString())
                ? @"User successfully set as Election Candidate"
                : @"Operation Failed");
            RefreshTable();
        }

        private void buttonRemoveCandidate_Click(object sender, EventArgs e)
        {
            if (_cr.RemoveUserFromCandidate(dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show(@"User successfully removed from Election Candidate");
            }
            else
            {
                MessageBox.Show(@"Operation Failed");
            }
            RefreshTable();
        }

        private void buttonViewResult_Click(object sender, EventArgs e)
        {
            new VoteResult().Show();
        }
    }
}
