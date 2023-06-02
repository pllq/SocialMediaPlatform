using System.Windows;
using System.Windows.Controls;
using BLL;

namespace SocialMediaPlatform
{
    /// <summary>
    /// Interaction logic for RegistrateOrLogin.xaml
    /// </summary>
    public partial class RegistrateOrLogin : Window
    {
        public RegistrateOrLogin()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            Width = 900; // Set the desired width
            Height = 600; // Set the desired height
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Button.Content == "Log in")
            {
                string LoginTextBoxText = LoginTextBox.Text;
                string PasswordTextBoxText = PasswordTextBox.Text;

                switch (BLL.RegistrateOrLoginFunctionality.NullOrEmpty(LoginTextBoxText, PasswordTextBoxText))
                {
                    case 0:
                        MessageBox.Show("You haven't written a login. Please try again.", "Login isn't written.");
                        break;

                    case 1:
                        MessageBox.Show("You haven't written a password. Please try again.", "Password is no written.");
                        break;
                }

                if (!BLL.RegistrateOrLoginFunctionality.LogIn(ref LoginTextBoxText, ref PasswordTextBoxText)) 
                {
                    MessageBox.Show("Wrong login or password.", "Access dinied.");
                    return;
                }

                MessageBox.Show("You have logged in into account!", "Login success.");
                InformationInput informationInput = new InformationInput();
                this.Close();
                informationInput.Show();
            }
            else
            {
                string LoginTextBoxText = LoginTextBox.Text;
                string PasswordTextBoxText = PasswordTextBox.Text;

                switch(BLL.RegistrateOrLoginFunctionality.NullOrEmpty(LoginTextBoxText, PasswordTextBoxText)) 
                {
                    case 0:
                        MessageBox.Show("You haven't written a login. Please try again.", "Login isn't written.");
                        break;

                    case 1:
                        MessageBox.Show("You haven't written a password. Please try again.", "Password is no written.");
                        break;
                }

                if (!BLL.RegistrateOrLoginFunctionality.SignUp(ref LoginTextBoxText, ref PasswordTextBoxText))
                {
                    MessageBox.Show("You have already created this account. You can login or create a new one.",
                                                        "Account is already created.");
                    return;
                }
                MessageBox.Show("You have created an account!", "Account created.");

                MainWindow mainwindow = new MainWindow();
                this.Close();
                mainwindow.Show();

                mainwindow.LoginButton.IsEnabled = true;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){}
    }
}
