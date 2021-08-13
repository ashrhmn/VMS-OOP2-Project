﻿using System;
using System.Windows.Forms;

namespace VMS.Views
{
    public partial class LoginView : Form
    {
        Action<string, string> _handleLogin;
        public LoginView(Action<string,string> handleLogin)
        {
            InitializeComponent();
            this._handleLogin = handleLogin;
            this.password.PasswordChar = '*';
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            _handleLogin(username.Text, password.Text);
        }
    }
}
