using System.Windows;
using System.Windows.Controls;

namespace SocialMediaPlatform
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private string Login = "";
        //private string Password = "";


        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            Width = 900; // Set the desired width
            Height = 600; // Set the desired height
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            RegistrateOrLogin registrateOrLogin = new RegistrateOrLogin();
            this.Close();
            registrateOrLogin.Show();


            if (clickedButton == LoginButton)
            {
                registrateOrLogin.Button.Content = "Log in";
            }
            else
            {
                registrateOrLogin.Button.Content = "Sign up";
            }

            /*            if (String.IsNullOrEmpty(LoginTextBox.Text) || String.IsNullOrWhiteSpace(LoginTextBox.Text))
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
                        Login =  LoginTextBox.Text;
                        Password = PasswordTextBox.Text;

                        if (Login.Any(Char.IsWhiteSpace))
                        {
                            Login = Login.Replace(" ", "");
                        }
                        if (Password.Any(Char.IsWhiteSpace))
                        {
                            Password = Password.Replace(" ", "");
                        }

                        MessageBox.Show("You created and account.", "Account created.");


                        RegistrateButton.Name = "Login";

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

                        if (LoginTextBox.Text == Login)
                        {
                            MessageBox.Show("You have logged in", "Login in success.");

                            return;
                        }
                        if (PasswordTextBox.Text == Password)
                        {
                            MessageBox.Show("You have logged in", "Login in success.");
                            return;
                        }

            */

            /*
             Registrate"
             LoginTextBox
             Login
             PasswordText
             Password
             
             
             */

            /*            MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();*/
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
