using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views
{
    public partial class VoteResult : Form
    {
        private VoteRepo vr;
        private UserDetailRepo _udr;
        public VoteResult()
        {
            InitializeComponent();
            vr = new VoteRepo();
            _udr = new UserDetailRepo();
            dataGridViewCandidates.DataSource = vr.CandidateResultDataTable();
            dataGridViewCandidates.Sort(dataGridViewCandidates.Columns[1],ListSortDirection.Descending);
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
                textBoxDateOfBirth.Text = userDetail.DateOfBirth.ToString();
                textBoxNid.Text = userDetail.NID;
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
