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
        Repository.UserRepo ur;
        Action handleLogout;
        public Dashboard(string username, Action handleLogout)
        {
            InitializeComponent();
            ur = new Repository.UserRepo();
            label1.Text = "Welcome, "+username + ur.getRole(username);
            this.handleLogout = handleLogout;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            handleLogout();
        }
    }
}
