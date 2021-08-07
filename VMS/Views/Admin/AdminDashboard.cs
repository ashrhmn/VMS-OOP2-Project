using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VMS.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        Repository.UserRepo ur;
        public AdminDashboard()
        {
            InitializeComponent();
            ur = new Repository.UserRepo();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            usersGridView.DataSource = ur.getUsersDataTable();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            int rows = ur.updateUsersDataTable();
            MessageBox.Show(rows + " users has been changed");
            usersGridView.DataSource = ur.getUsersDataTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            usersGridView.DataSource = ur.getUsersDataTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int totalRow = usersGridView.Rows.Count;
            foreach(DataGridViewRow row in usersGridView.SelectedRows)
            {
                if(row.Index == totalRow-1 || row.Index == -1)
                {
                    MessageBox.Show("Select a user to be deleted");
                }
                else
                {
                    usersGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUsername.Text = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPassword.Text = usersGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxRole.SelectedIndex = comboBoxRole.FindStringExact(usersGridView.SelectedRows[0].Cells[2].Value.ToString());
        }
    }
}
