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
        public new Form ActiveForm;
        public MainView()
        {
            InitializeComponent();

            ActivatePanel(new Views.LoginView(HandleLogin));
        }


        void ActivatePanel(Form formToActivate)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            this.ActiveForm = formToActivate;
            formToActivate.TopLevel = false;
            formToActivate.FormBorderStyle = FormBorderStyle.None;
            formToActivate.Dock = DockStyle.Fill;
            this.panelMainView.Controls.Add(formToActivate);
            this.panelMainView.Tag = formToActivate;
            formToActivate.BringToFront();
            formToActivate.Show();
        }

        void HandleSignUp(string username, string password)
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

        void HandleLogin(string username, string password)
        {
            Repository.UserRepo ur = new Repository.UserRepo();
            if (ur.IsAuthenticated(username, password))
            {
                MessageBox.Show("Logged in as "+username);
                ActivatePanel(new Views.Dashboard(username,HandleLogout));
            }
            else
            {
                MessageBox.Show(@"Invalid username or password");
            }
        }

        void HandleLogout()
        {
            ActivatePanel(new Views.LoginView(HandleLogin));
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
