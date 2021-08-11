using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views.GeneralPublic
{
    public partial class GeneralPublicDashboard : Form
    {
        private readonly UserDetailRepo _udr;
        private CandidateRepo cr;
        private VoteRepo vr;
        private string Username;
        public GeneralPublicDashboard(string username)
        {
            InitializeComponent();
            this.Username = username;
            _udr = new UserDetailRepo();
            cr = new CandidateRepo();
            vr = new VoteRepo();
            RefreshData();
            UpdateVotingInfo();
        }

        void UpdateVotingInfo()
        {
            dataGridViewCandidates.DataSource = cr.GetCandidateListTable();
            bool userHasVoted = vr.HasVoted(Username);
            buttonVote.Enabled = !userHasVoted;
            if (userHasVoted)
            {
                labelVoteInfo.Text = "You have voted for : \n"+vr.VotedCandidate(Username);
            }
            else
            {
                labelVoteInfo.Text = "You haven't voted yet";
            }
        }

        void RefreshData()
        {
            UserDetail userDetail = _udr.GetUserDetail(Username);
            if (userDetail != null)
            {
                textBoxUsername.Text = userDetail.UserName;
                textBoxName.Text = userDetail.Name;
                textBoxFathername.Text = userDetail.FatherName;
                textBoxMotherName.Text = userDetail.MotherName;
                textBoxGender.Text = userDetail.Gender;
                textBoxAddress.Text = userDetail.Address;
                textBoxDateOfBirth.Text = userDetail.DateOfBirth.ToString();
                textBoxNid.Text = userDetail.NID;
            }


        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            if (vr.VoteCandidate(Username,
                dataGridViewCandidates.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("You have voted successfully");
            }
            else
            {
                MessageBox.Show("Voting Failed, Please contact your District Manager");
            }
            UpdateVotingInfo();
            //MessageBox.Show(dataGridViewCandidates.SelectedRows[0].Cells[0].Value.ToString());

        }
    }
}
