using System;
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
            comboBoxOperationMode.SelectedIndex = 0;
            comboBoxRole.SelectedIndex = 0;
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
            foreach (DataGridViewRow row in usersGridView.SelectedRows)
            {
                if (row.Index == totalRow - 1 || row.Index == -1)
                {
                    MessageBox.Show("Select a user to be deleted");
                }
                else
                {
                    usersGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        public void fetchSelectedDataToTextBoxes()
        {
            textBoxUsername.Text = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPassword.Text = usersGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxRole.SelectedIndex = comboBoxRole.FindStringExact(usersGridView.SelectedRows[0].Cells[2].Value.ToString());
        }

        public void emptyTextBoxes()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBoxRole.Text = "";
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fetchSelectedDataToTextBoxes();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxOperationMode.SelectedIndex == 0)
            {
                //Update
                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("");
                }
                else
                {
                    if (ur.updateUser(
                        new Entity.User(
                            textBoxUsername.Text,
                            textBoxPassword.Text,
                            comboBoxRole.Text
                            ),
                        usersGridView.SelectedRows[0].Cells[0].Value.ToString() //username from selected row
                        ))
                    {
                        MessageBox.Show("Updated successfullly");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
            }
            else
            {
                //Add
            }

            emptyTextBoxes();
            usersGridView.DataSource = ur.getUsersDataTable();
        }


        private void comboBoxOperationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperationMode.SelectedIndex == 0)
            {
                //Update Mode
                buttonUpdate.Text = "Update";
                buttonDelete.Enabled = true;
            }
            else
            {
                //Add Mode
                buttonUpdate.Text = "Add";
                buttonDelete.Enabled = false;
            }
            MessageBox.Show("" + comboBoxRole.SelectedIndex);
        }
    }
}
