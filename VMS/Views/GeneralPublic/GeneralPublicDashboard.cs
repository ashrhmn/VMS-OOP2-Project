using System;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views.GeneralPublic
{
    public partial class GeneralPublicDashboard : Form
    {
        private readonly UserDetailRepo _udr;
        private readonly CandidateRepo _cr;
        private readonly VoteRepo _vr;
        private readonly string _username;
        public GeneralPublicDashboard(string username)
        {
            InitializeComponent();
            this._username = username;
            _udr = new UserDetailRepo();
            _cr = new CandidateRepo();
            _vr = new VoteRepo();
            RefreshData();
            UpdateVotingInfo();
        }

        private void UpdateVotingInfo()
        {
            dataGridViewCandidates.DataSource = _cr.GetCandidateListTable();
            bool userHasVoted = _vr.HasVoted(_username);
            buttonVote.Enabled = !userHasVoted;
            if (userHasVoted)
            {
                labelVoteInfo.Text = @"You have voted for : "+_vr.VotedCandidate(_username);
            }
            else
            {
                labelVoteInfo.Text = @"You haven't voted yet";
            }
        }

        private void RefreshData()
        {
            UserDetail userDetail = _udr.GetUserDetail(_username);
            if (userDetail != null)
            {
                textBoxUsername.Text = userDetail.UserName;
                textBoxName.Text = userDetail.Name;
                textBoxFathername.Text = userDetail.FatherName;
                textBoxMotherName.Text = userDetail.MotherName;
                textBoxGender.Text = userDetail.Gender;
                textBoxAddress.Text = userDetail.Address;
                textBoxNid.Text = userDetail.NID;
                dateOfBirthPicker.Value = Convert.ToDateTime(userDetail.DateOfBirth.ToString("yyyy/MM/dd"));
            }
            else
            {
                textBoxUsername.Text = "";
                textBoxName.Text = "";
                textBoxFathername.Text = "";
                textBoxMotherName.Text = "";
                textBoxGender.Text = "";
                textBoxAddress.Text = "";
                dateOfBirthPicker.Value = DateTime.Now;
                textBoxNid.Text = "";
            }
        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_vr.VoteCandidate(_username,
                dataGridViewCandidates.SelectedRows[0].Cells[0].Value.ToString())
                ? @"You have voted successfully"
                : @"Voting Failed, Please contact your District Manager");
            UpdateVotingInfo();
        }

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_udr.UpdateUserDetail(new UserDetail(textBoxUsername.Text,
                textBoxName.Text,
                textBoxFathername.Text,
                textBoxMotherName.Text,
                textBoxGender.Text,
                dateOfBirthPicker.Value,
                textBoxNid.Text,
                textBoxAddress.Text))
                ? "User Details Updated Successfully"
                : "User Detail Update Failed");
            RefreshData();
        }
    }
}
