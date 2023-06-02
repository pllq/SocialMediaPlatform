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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
