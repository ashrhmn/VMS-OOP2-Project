using System;
using System.Drawing;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS
{
    public partial class MainView : Form
    {
        private UserRepo ur;
        public new Form ActiveForm;
        public MainView()
        {
            InitializeComponent();
            ur = new UserRepo();

            ActivatePanel(new Views.LoginView(HandleLogin, HandleSignUp));
        }


        void ActivatePanel(Form formToActivate)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = formToActivate;
            formToActivate.TopLevel = false;
            formToActivate.FormBorderStyle = FormBorderStyle.None;
            formToActivate.Dock = DockStyle.Fill;
            panelMainView.Controls.Add(formToActivate);
            panelMainView.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }

        void HandleSignUp(string username, string password)
        {
            if (ur.AddUser(new User(username, password, "General Public")))
            {
                MessageBox.Show(@"Sign Up Successful, Add your Details on next page");
                ActivatePanel(new Views.Dashboard(username, HandleLogout));
            }
            else
            {
                MessageBox.Show(@"Sign Up Failed");
            }
        }

        void HandleLogin(string username, string password)
        {
            if (ur.IsAuthenticated(username, password))
            {
                MessageBox.Show(@"Logged in as "+username);
                ActivatePanel(new Views.Dashboard(username,HandleLogout));
            }
            else
            {
                MessageBox.Show(@"Invalid username or password");
            }
        }

        void HandleLogout()
        {
            ActivatePanel(new Views.LoginView(HandleLogin,HandleSignUp));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }
    }
}
