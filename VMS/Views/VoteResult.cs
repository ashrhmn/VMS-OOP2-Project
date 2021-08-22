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
            MakeDataGridViewNotSortable();
            UpdateVoteInfo();
        }

        void MakeDataGridViewNotSortable()
        {
            foreach (DataGridViewColumn column in dataGridViewCandidates.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        void UpdateVoteInfo()
        {
            string woningCandidateUsername = GetDataGridViewDataToString(0, 0);
            try
            {
                int wonByVote = int.Parse(GetDataGridViewDataToString(0, 1)) - int.Parse(GetDataGridViewDataToString(1, 1));
                if (wonByVote > 0)
                {
                    labelVoteResultInfo.Text = _udr.GetUserFullName(woningCandidateUsername) + " (" + woningCandidateUsername + ")" + " has own by " + wonByVote.ToString() + " vote(s)";
                }
                else
                {
                    labelVoteResultInfo.Text = "Election tie between candidates " + GetDataGridViewDataToString(0, 0) + " (" + _udr.GetUserFullName(GetDataGridViewDataToString(0, 0)) + ") and " + GetDataGridViewDataToString(1, 0) + " (" + _udr.GetUserFullName(GetDataGridViewDataToString(1, 0)) + ")";
                }
            }
            catch (Exception ex)
            {
                new LocalRepo().ShowErrorMessage(ex, "VoteResult.cs", 40);
                labelVoteResultInfo.Text = "Error showing vote result..";
            }
        }

        void UpdateCandidateTable()
        {
            dataGridViewCandidates.DataSource = _vr.CandidateResultDataTable();
            dataGridViewCandidates.Sort(dataGridViewCandidates.Columns[1], ListSortDirection.Descending);
        }

        string GetDataGridViewDataToString(int rowNo, int columnNo)
        {
            return dataGridViewCandidates.Rows[rowNo].Cells[columnNo].Value.ToString();
        }

        //int TryDataGridViewDataToStringToInt(int rowNo, int columnNo)
        //{
        //    string data = GetDataGridViewDataToString(rowNo, columnNo);
        //    try
        //    {
        //        return int.Parse(data);
        //    }
        //    catch (Exception ex)
        //    {
        //        new LocalRepo().ShowCustomErrorMessage(ex, "Error parsing "+data+" to Int");
        //        return 0;
        //    }
        //}

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
