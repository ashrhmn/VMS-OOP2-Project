using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        private DataTable _usersDataTable;
        readonly UserRepo _ur;
        readonly LocalRepo _lr;
        public AdminDashboard()
        {
            InitializeComponent();
            _ur = new UserRepo();
            _lr = new LocalRepo();
            comboBoxOperationMode.SelectedIndex = 0;
            comboBoxRole.SelectedIndex = 0;
            UpdateDataTable();
            userNameErrorLabel.Text = "";
        }

        public void UpdateDataTable()
        {
            _usersDataTable = _ur.GetUsersDataTable();
            usersGridView.DataSource = _usersDataTable;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateDataTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateDataTable();
        }


        public void FetchSelectedDataToTextBoxes()
        {
            textBoxUsername.Text = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPassword.Text = usersGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxRole.SelectedIndex = comboBoxRole.FindStringExact(usersGridView.SelectedRows[0].Cells[2].Value.ToString());
        }

        public void EmptyTextBoxes()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBoxRole.Text = "";
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FetchSelectedDataToTextBoxes();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text == "")
            {
                MessageBox.Show(@"Username can not be empty");
            }
            else
            {
                if (comboBoxOperationMode.SelectedIndex == 0)
                {
                    //Update
                    MessageBox.Show(_ur.UpdateUser(
                        new User(
                            textBoxUsername.Text,
                            textBoxPassword.Text,
                            comboBoxRole.Text
                        ),
                        usersGridView.SelectedRows[0].Cells[0].Value.ToString() //username from selected row
                    )
                        ? @"Updated successfully"
                        : @"Update Failed");
                }
                else
                {
                    //Add
                    MessageBox.Show(_ur.AddUser(new User(
                        textBoxUsername.Text,
                        textBoxPassword.Text,
                        comboBoxRole.Text
                    ))
                        ? @"User added successfully"
                        : @"User add Failed");
                }

                EmptyTextBoxes();
                UpdateDataTable();
            }
            
        }


        private void comboBoxOperationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperationMode.SelectedIndex == 0)
            {
                //Update Mode
                buttonUpdate.Text = @"Update";
                buttonDelete.Enabled = true;
            }
            else
            {
                //Add Mode
                buttonUpdate.Text = @"Add";
                buttonDelete.Enabled = false;
            }
            CheckUsernameAvailability();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show(@"Select a user to be deleted", @"Error");
            }
            else
            {
                var confirmResult = MessageBox.Show(@"Are you sure to delete this item ?",
                                     @"Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(_ur.DeleteUser(textBoxUsername.Text)
                        ? @"User deleted successfully"
                        : @"Delete Error");
                }
                EmptyTextBoxes();
                UpdateDataTable();
            }
        }

        void CheckUsernameAvailability()
        {
            if (comboBoxOperationMode.SelectedIndex == 1)
            {
                foreach (User user in _lr.ConvertDataTableToList<User>(_usersDataTable).ToArray())
                {
                    if (user.Username == textBoxUsername.Text)
                    {
                        userNameErrorLabel.Text = @"❌";
                        userNameErrorLabel.ForeColor = Color.OrangeRed;
                        textBoxUsername.ForeColor = Color.OrangeRed;
                        buttonUpdate.Enabled = false;

                        break;
                    }

                    userNameErrorLabel.Text = textBoxUsername.Text == "" ? "" : @"✅";
                    userNameErrorLabel.ForeColor = Color.LimeGreen;
                    textBoxUsername.ForeColor = Color.Black;
                    buttonUpdate.Enabled = true;
                }
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            CheckUsernameAvailability();
        }

        private void buttonViewResult_Click(object sender, EventArgs e)
        {
            new VoteResult().ShowDialog(this);
        }
    }
}
