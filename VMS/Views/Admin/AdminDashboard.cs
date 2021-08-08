using System;
using System.Collections.Generic;
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
            usersGridView.DataSource = ur.GetUsersDataTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            usersGridView.DataSource = ur.GetUsersDataTable();
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
                usersGridView.DataSource = ur.GetUsersDataTable();
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
                buttonUpdate.Text = "Add";
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Select a user to be deleted", "Error");
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
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
                usersGridView.DataSource = ur.GetUsersDataTable();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            List<Entity.User> userList = ur.GetUsersDataList();
            String message = "";
            foreach (Entity.User user in userList){
                System.Diagnostics.Debug.WriteLine(user.Username+"\n");
                //message += user.Username+"\n\n";
            }
            userList.ForEach(delegate (Entity.User user)
            {
                message += user.Username + "\n\n";
            });
            MessageBox.Show(message);

        }
    }
}
