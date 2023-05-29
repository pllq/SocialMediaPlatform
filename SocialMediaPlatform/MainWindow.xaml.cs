using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml;

namespace SocialMediaPlatform
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string Login;
        private string Password;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text) || String.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                MessageBox.Show("You haven't written a login. Please try again.", "Login is no written.");
                //throw new ApplicationException("Customer name is mandatory.");
                return;
            }
            if (String.IsNullOrEmpty(PasswordTextBox.Text) || String.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("You haven't written a password. Please try again.", "Password is no written.");
                //throw new ApplicationException("Customer name is mandatory.");
                return;
            }
            Login = LoginTextBox.Text;
            Password = PasswordTextBox.Text;

            if (Login.Any(Char.IsWhiteSpace))
            {
                Login = Login.Replace(" ", "");
            }
            if (Password.Any(Char.IsWhiteSpace))
            {
                Password = Password.Replace(" ", "");
            }


            /*            MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();*/
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
