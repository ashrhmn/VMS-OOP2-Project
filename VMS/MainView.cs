using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMS
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            activatePanel(new Views.LoginView(handleLogin));
        }

        public Form activeForm { get; private set; }

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
            this.panelMainView.Controls.Add(formToActivate);
            this.panelMainView.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }

        void handleSignUp(string username, string password)
        {
            SqlConnection conn = new SqlConnection("Data Source=1.10.11.107;Initial Catalog=VMS;Persist Security Info=True;User ID=sa;Password=mssql-2019");
            //activatePanel(new Views.Dashboard());
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into users (username, password) values('" + username + "','" + password + "')", conn);
            int rowsAffected = 0;
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            MessageBox.Show(rowsAffected + " rows affected");
            conn.Close();
        }

        void handleLogin(string username, string password)
        {
            Repository.UserRepo ur = new Repository.UserRepo();
            if (ur.isAuthenticated(username, password))
            {
                MessageBox.Show("Logged in as "+username);
                activatePanel(new Views.Dashboard(username,handleLogout));
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        void handleLogout()
        {
            activatePanel(new Views.LoginView(handleLogin));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Blue;
            //label1.Image = Image.FromFile("\\\\Mac\\Dropbox\\sourcecode\\VisualStudio\\VMS\\VMS\\VMS\\Resources\\outline_power_settings_new_black_24dp.png");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
            //label1.Image = null;
        }
    }
}
