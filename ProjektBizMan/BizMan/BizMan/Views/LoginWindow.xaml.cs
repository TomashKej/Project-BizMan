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

namespace BizMan.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordBox.Password;

            // Simple authentication logic
            if (username == "grandAdmin" && password == "Admin123!")
            {
                // Logowanie udane
                MainMenuWindow mainMenuWindow = new MainMenuWindow();
                mainMenuWindow.Show();

                this.Close(); // shut down the login window
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Try again.", "Login error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
