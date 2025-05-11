using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PW3
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool hasError = false;
            txtResult.Text = "";

            txtUsername.ClearValue(BorderBrushProperty);
            pwdPassword.ClearValue(BorderBrushProperty);

            if(string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtResult.Text += "Введіть логін. \n";
                txtUsername.BorderBrush = Brushes.Red;
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(pwdPassword.Password))
            {
                txtResult.Text += "Введіть пароль. \n";
                pwdPassword.BorderBrush = Brushes.Red;
                hasError = true;
            }

            if (!hasError)
            {
                txtResult.Foreground = Brushes.Green;
                txtResult.Text = "Вхід успішний!";
            }
            else
            {
                txtResult.Foreground = Brushes.Red;
            }

            Login();
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Login();
        }

        private void Login()
        {
            string username = txtUsername.Text;
            string password = pwdPassword.Password;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                txtResult.Text = "Вхід успішний!";
                txtResult.Foreground = System.Windows.Media.Brushes.Green;
            }
        }
    }
}
