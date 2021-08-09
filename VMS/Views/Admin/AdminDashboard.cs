using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VMS.Entity;

namespace VMS.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        private System.Data.DataTable usersDataTable;
        Repository.UserRepo ur;
        Repository.LocalRepo lr;
        public AdminDashboard()
        {
            InitializeComponent();
            ur = new Repository.UserRepo();
            lr = new Repository.LocalRepo();
            comboBoxOperationMode.SelectedIndex = 0;
            comboBoxRole.SelectedIndex = 0;
            UpdateDataTable();
            userNameErrorLabel.Text = "";
        }

        public void UpdateDataTable()
        {
            usersDataTable = ur.GetUsersDataTable();
            usersGridView.DataSource = usersDataTable;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateDataTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateDataTable();
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

            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else
            {
                if (comboBoxOperationMode.SelectedIndex == 0)
                {
                    //Update
                    if (ur.UpdateUser(
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
                else
                {
                    //Add
                    if (ur.AddUser(new Entity.User(
                                textBoxUsername.Text,
                                textBoxPassword.Text,
                                comboBoxRole.Text
                        )))
                    {
                        MessageBox.Show("User added successfullly");
                    }
                    else
                    {
                        MessageBox.Show("User add Failed");
                    }
                }

                emptyTextBoxes();
                UpdateDataTable();
            }
            
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
                buttonUpdate.Text = @"Add";
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show(@"Select a user to be deleted", @"Error");
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (ur.DeleteUser(textBoxUsername.Text))
                    {
                        MessageBox.Show("User deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Delete Error");
                    }

                }
                emptyTextBoxes();
                UpdateDataTable();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxOperationMode.SelectedIndex == 1)
            {
                if (textBoxUsername.Text == "" || textBoxUsername.Text == usersGridView.SelectedRows[0].Cells[0].Value.ToString())
                {
                    UpdateDataTable();
                }

                foreach (Entity.User user in lr.ConvertDataTableToList<Entity.User>(usersDataTable).ToArray())
                {
                    if (user.Username == textBoxUsername.Text)
                    {
                        userNameErrorLabel.Text = @"❌";
                        userNameErrorLabel.ForeColor = Color.OrangeRed;
                        textBoxUsername.ForeColor = Color.OrangeRed;
                        buttonUpdate.Enabled = false;

                        break;
                    }

                    if (textBoxUsername.Text == "")
                    {
                        userNameErrorLabel.Text = "";
                    }
                    else
                    {
                        userNameErrorLabel.Text = @"✅";
                    }
                    userNameErrorLabel.ForeColor = Color.LimeGreen;
                    textBoxUsername.ForeColor = Color.Black;
                    buttonUpdate.Enabled = true;
                }
            }
        }
    }
}
