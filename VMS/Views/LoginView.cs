using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VMS.Views
{
    public partial class LoginView : Form
    {
        Action<string, string> handleLogin;
        public LoginView(Action<string,string> handleLogin)
        {
            InitializeComponent();
            this.handleLogin = handleLogin;
            this.password.PasswordChar = '*';
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            handleLogin(username.Text, password.Text);
        }
    }
}
