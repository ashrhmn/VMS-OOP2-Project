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
            _username = username;
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
                string votedCandidateUsername = _vr.VotedCandidate(_username);
                labelVoteInfo.Text = @"You have voted for : "+_udr.GetUserFullName(votedCandidateUsername)+" ("+votedCandidateUsername+")";
            }
            else
            {
                labelVoteInfo.Text = @"You haven't voted yet";
            }
        }

        private void RefreshData()
        {
            textBoxUsername.Text = _username;
            UserDetail userDetail = _udr.GetUserDetail(_username);
            if (userDetail != null)
            {
                textBoxName.Text = userDetail.Name;
                textBoxFathername.Text = userDetail.FatherName;
                textBoxMotherName.Text = userDetail.MotherName;
                comboBoxGender.SelectedIndex = comboBoxGender.FindStringExact(userDetail.Gender);
                textBoxAddress.Text = userDetail.Address;
                textBoxNid.Text = userDetail.Nid;
                try
                {
                    dateOfBirthPicker.Value = Convert.ToDateTime(userDetail.DateOfBirth.ToString("yyyy/MM/dd"));
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
                
            }
            else
            {
                textBoxName.Text = "";
                textBoxFathername.Text = "";
                textBoxMotherName.Text = "";
                comboBoxGender.Text = "";
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
            MessageBox.Show(_udr.SaveUserDetail(new UserDetail(textBoxUsername.Text,
                textBoxName.Text,
                textBoxFathername.Text,
                textBoxMotherName.Text,
                comboBoxGender.Text,
                dateOfBirthPicker.Value,
                textBoxNid.Text,
                textBoxAddress.Text))
                ? "User Details Updated Successfully"
                : "User Detail Update Failed");
            RefreshData();
            UpdateCandidateDetails();
        }

        void UpdateCandidateDetails()
        {
            UserDetail userDetail = _udr.GetUserDetail(dataGridViewCandidates.SelectedRows[0].Cells[0].Value.ToString());
            if (userDetail != null)
            {
                textBoxCandidateName.Text = userDetail.Name;
                textBoxCandidateFathername.Text = userDetail.FatherName;
                textBoxCandidateMothername.Text = userDetail.MotherName;
                textBoxCandidateGender.Text = userDetail.Gender;
                textBoxCandidateAddress.Text = userDetail.Address;
                textBoxCandidateNid.Text = userDetail.Nid;
                textBoxCandidateDateOfBirth.Text = userDetail.DateOfBirth.ToString("yyyy/MM/dd");
            }
            else
            {
                textBoxCandidateName.Text = "";
                textBoxCandidateFathername.Text = "";
                textBoxCandidateMothername.Text = "";
                textBoxCandidateGender.Text = "";
                textBoxCandidateAddress.Text = "";
                textBoxCandidateDateOfBirth.Text = "";
                textBoxCandidateNid.Text = "";
            }
        }

        private void dataGridViewCandidates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCandidateDetails();
        }
    }
}
