using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VMS.Repository;

namespace VMS.Views
{
    public partial class VoteResult : Form
    {
        private VoteRepo vr;
        public VoteResult()
        {
            InitializeComponent();
            vr = new VoteRepo();
            dataGridViewCandidates.DataSource = vr.CandidateListDataTable();
        }
    }
}
