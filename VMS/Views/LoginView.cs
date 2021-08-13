using System;
using System.Windows.Forms;

namespace VMS.Views
{
    public partial class LoginView : Form
    {
        readonly Action<string, string> _handleLogin;
        readonly Action<string, string> _handleSignUp;
        public LoginView(Action<string,string> handleLogin, Action<string, string> handleSignUp)
        {
            InitializeComponent();
            _handleLogin = handleLogin;
            _handleSignUp = handleSignUp;
            password.PasswordChar = '*';
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            _handleLogin(username.Text, password.Text);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            _handleSignUp(username.Text, password.Text);
        }
    }
}
