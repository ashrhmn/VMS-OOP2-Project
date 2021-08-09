using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VMS.Repository;

namespace VMS.Views.DistrictManager
{
    public partial class DistrictManagerDashboard : Form
    {
        private UserRepo ur;
        public DistrictManagerDashboard()
        {
            InitializeComponent();
            ur = new UserRepo();
            dataGridViewPublic.DataSource = ur.GetGeneralPublicDataTable();
        }

        private void dataGridViewPublic_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
