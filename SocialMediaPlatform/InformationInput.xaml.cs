using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace SocialMediaPlatform
{
    /// <summary>
    /// Interaction logic for InformationInput.xaml
    /// </summary>
    public partial class InformationInput : Window
    {
        string id;
        string name;
        string username;
        string email;
        string date_of_birth;
        string profile_picture;


        public InformationInput()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            Width = 900; // Set the desired width
            Height = 600; // Set the desired height
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PPButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (openFileDialog.ShowDialog() == true) 
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                profile_picture = filePath;
            }
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            BLL.InformationInputFunctionality.SaveData(id, name, username, email, date_of_birth, profile_picture);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            id = IDTextBox.Text;
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            username = UsernameTextBox.Text; 
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            email = EmailTextBox.Text;
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = NameTextBox.Text;
        }

        private void DOBTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            date_of_birth = DOBTextBox.Text;
        }
    }
}
