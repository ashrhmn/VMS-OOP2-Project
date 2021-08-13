using System;
using System.Windows.Forms;

namespace VMS.Views
{
    public partial class Dashboard : Form
    {
        Form _activeForm;
        readonly Repository.UserRepo _ur;
        readonly Action _handleLogout;
        public Dashboard(string username, Action handleLogout)
        {
            InitializeComponent();
            this._handleLogout = handleLogout;
            _ur = new Repository.UserRepo();
            string role = _ur.GetRole(username);
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
                    ActivatePanel(new DistrictManager.DistrictManagerDashboard());
                }
                else
                {
                    MessageBox.Show(@"Invalid Role, Logging out...");
                    handleLogout();
                }
            }
            userInfo.Text = "Welcome, "+username;
            userRoleInfo.Text = "User Role : "+role;
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
            this._activeForm = formToActivate;
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
