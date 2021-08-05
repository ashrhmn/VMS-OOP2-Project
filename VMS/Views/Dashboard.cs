using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VMS.Views
{
    public partial class Dashboard : Form
    {
        Form activeForm;
        Repository.UserRepo ur;
        Action handleLogout;
        public Dashboard(string username, Action handleLogout)
        {
            InitializeComponent();
            this.handleLogout = handleLogout;
            ur = new Repository.UserRepo();
            string role = ur.getRole(username);
            if (role!=null)
            {
                if (role == "admin")
                {
                    activatePanel(new Admin.AdminDashboard());
                }
                else if (role == "generalPublic")
                {

                }
                else if (role == "districtManager")
                {

                }
                else
                {
                    handleLogout();
                }
            }
            userInfo.Text = "Welcome, "+username;
            userRoleInfo.Text = "User Role : "+role;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            handleLogout();
        }

        void activatePanel(Form formToActivate)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            this.activeForm = formToActivate;
            formToActivate.TopLevel = false;
            formToActivate.FormBorderStyle = FormBorderStyle.None;
            formToActivate.Dock = DockStyle.Fill;
            this.dashboardViewPanel.Controls.Add(formToActivate);
            this.dashboardViewPanel.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }
    }
}
