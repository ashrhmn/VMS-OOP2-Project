using System;
using System.ComponentModel;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views
{
    public partial class VoteResult : Form
    {
        private readonly VoteRepo _vr;
        private readonly UserDetailRepo _udr;
        public VoteResult()
        {
            InitializeComponent();
            _vr = new VoteRepo();
            _udr = new UserDetailRepo();
            UpdateCandidateTable();
        }

        void UpdateCandidateTable()
        {
            dataGridViewCandidates.DataSource = _vr.CandidateResultDataTable();
            dataGridViewCandidates.Sort(dataGridViewCandidates.Columns[1], ListSortDirection.Descending);

            foreach (DataGridViewColumn column in dataGridViewCandidates.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            string woningCandidateUsername = dataGridViewCandidates.Rows[0].Cells[0].Value.ToString();

            int wonByVote = 0;

            try
            {
                wonByVote = int.Parse(dataGridViewCandidates.Rows[0].Cells[1].Value.ToString())- int.Parse(dataGridViewCandidates.Rows[1].Cells[1].Value.ToString()); 
            }
            catch (Exception ex)
            {
                new LocalRepo().ShowErrorMessage(ex,"VoteResult.cs",40);
            }

            labelVoteResultInfo.Text = _udr.GetUserFullName(woningCandidateUsername)+" ("+woningCandidateUsername +")"+ " has own by "+wonByVote.ToString()+" votes";
        }

        private void dataGridViewCandidates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData(dataGridViewCandidates.SelectedRows[0].Cells[0].Value.ToString());
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
                textBoxDateOfBirth.Text = userDetail.DateOfBirth.ToString("dd MMM yyyy");
                textBoxNid.Text = userDetail.Nid;
            }
            else
            {
                textBoxUsername.Text = "";
                textBoxName.Text = "";
                textBoxFathername.Text = "";
                textBoxMotherName.Text = "";
                textBoxGender.Text = "";
                textBoxAddress.Text = "";
                textBoxDateOfBirth.Text = "";
                textBoxNid.Text = "";
            }
        }
    }
}
