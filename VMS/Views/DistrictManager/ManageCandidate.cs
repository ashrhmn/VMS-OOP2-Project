using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views.DistrictManager
{
    public partial class ManageCandidate : Form
    {

        private readonly UserDetailRepo _udr;
        private readonly CandidateRepo _cr;
        private readonly string _username;
        public ManageCandidate(string username)
        {
            InitializeComponent();
            _username = username;
            _udr = new UserDetailRepo();
            _cr = new CandidateRepo();

            //this.mainPanel = panelView;

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
                textBoxNid.Text = userDetail.Nid;
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

        private void buttonAddCandidate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cr.SetUserAsCandidate(dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString())
                ? @"User successfully set as Election Candidate"
                : @"Operation Failed");
            RefreshTable();
            buttonRemoveCandidate.Enabled = false;
            buttonAddCandidate.Enabled = false;
        }

        private void buttonRemoveCandidate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cr.RemoveUserFromCandidate(dataGridViewPublic.SelectedRows[0].Cells[0].Value.ToString())
                ? @"User successfully removed from Election Candidate"
                : @"Operation Failed");
            RefreshTable();
            buttonRemoveCandidate.Enabled = false;
            buttonAddCandidate.Enabled = false;
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
    }
}
