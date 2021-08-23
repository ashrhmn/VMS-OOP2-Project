using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VMS.Views.Admin
{
    public partial class ManageSignUps : Form
    {
        Repository.UserRepo ur;
        Repository.UserDetailRepo udr;
        public ManageSignUps()
        {
            InitializeComponent();
            ur = new Repository.UserRepo();
            udr = new Repository.UserDetailRepo();
            UpdateGridView();
        }

        void UpdateGridView()
        {
            usersGridView.DataSource = ur.GetPendingUsersDataTable();
        }

        string GetDataGridViewDataToString(int rowNo, int columnNo)
        {
            return usersGridView.Rows[rowNo].Cells[columnNo].Value.ToString();
        }

        private void buttonAutogen_Click(object sender, EventArgs e)
        {
            textBoxNid.Text = new Random().Next(100000000, 999999999).ToString();
        }

        private void buttonApproveSignup_Click(object sender, EventArgs e)
        {
            string username = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
            string password = usersGridView.SelectedRows[0].Cells[1].Value.ToString();

            if (ur.AddUser(new Entity.User(username,password,"General Public"))) //Approve User
            {
                MessageBox.Show("User approved");
                if (ur.DeletePendingUser(username)) //Delete Pending Requesst
                {
                    MessageBox.Show("Removed pending request for the user");
                    if (textBoxNid.Text != "")
                    {
                        Entity.UserDetail userDetail = new Entity.UserDetail();
                        userDetail.UserName = username;
                        userDetail.Nid = textBoxNid.Text;
                        if (udr.SaveUserDetail(userDetail))
                        {
                            MessageBox.Show("NID has been set for the new User");
                        }
                        else
                        {
                            MessageBox.Show("NID setting failed for the new user");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Removing the pending request failed");
                }
            }
            else
            {
                MessageBox.Show("User approve failed");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username = usersGridView.SelectedRows[0].Cells[0].Value.ToString();
            if (ur.DeletePendingUser(username))
            {
                MessageBox.Show("Removed pending request for the user");
            }
            else
            {
                MessageBox.Show("Removing the pending request failed");
            }
        }
    }
}
