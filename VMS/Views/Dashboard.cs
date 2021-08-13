using System;
using System.Windows.Forms;
using VMS.Repository;

namespace VMS.Views
{
    public partial class Dashboard : Form
    {
        Form _activeForm;
        readonly Action _handleLogout;
        public Dashboard(string username, Action handleLogout)
        {
            InitializeComponent();
            _handleLogout = handleLogout;
            //var ur = new Repository.UserRepo();
            string role = new UserRepo().GetRole(username);
            if (role!=null)
            {
                if (role == "Admin")
                {
                    ActivatePanel(new Admin.AdminDashboard());
                }
                else if (role == "General Public")
                {
                    ActivatePanel(new GeneralPublic.GeneralPublicDashboard(username));
                }
                else if (role == "District Manager")
                {
                    ActivatePanel(new DistrictManager.DistrictManagerDashboard(username));
                }
                else
                {
                    MessageBox.Show(@"Invalid Role, Logging out...");
                    handleLogout();
                }
            }
            userInfo.Text = @"Welcome, "+username;
            userRoleInfo.Text = @"User Role : "+role;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            _handleLogout();
        }

        void ActivatePanel(Form formToActivate)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = formToActivate;
            formToActivate.TopLevel = false;
            formToActivate.FormBorderStyle = FormBorderStyle.None;
            formToActivate.Dock = DockStyle.Fill;
            dashboardViewPanel.Controls.Add(formToActivate);
            dashboardViewPanel.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }
    }
}
