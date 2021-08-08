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
            string role = ur.GetRole(username);
            if (role!=null)
            {
                if (role == "Admin")
                {
                    activatePanel(new Admin.AdminDashboard());
                }
                else if (role == "General Public")
                {
                    activatePanel(new GeneralPublic.GeneralPublicDashboard());
                }
                else if (role == "District Manager")
                {
                    activatePanel(new DistrictManager.DistrictManagerDashboard());
                }
                else
                {
                    MessageBox.Show("Invalid Role, Logging out...");
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
