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
        public GeneralPublicDashboard(string username)
        {
            InitializeComponent();
            _udr = new UserDetailRepo();
            cr = new CandidateRepo();
            vr = new VoteRepo();
            RefreshData(username);
            UpdateCandidateListTable();
        }

        void UpdateCandidateListTable()
        {
            dataGridViewCandidates.DataSource = cr.GetCandidateListTable();
        }

        void RefreshData(string username)
        {
            UserDetail userDetail = _udr.GetUserDetail(username);
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

            labelVoteInfo.Text = vr.VotedCandidate(username);

        }
    }
}
