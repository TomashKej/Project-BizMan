/*** 
 *  This class represents the main menu window of the BizMan application.
 *  It contains buttons for navigating to different sections of the application,
 *  It also represents the main user interface for managing business operations.
 ***/

using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BizMan.Views
{
    /// <summary>
    /// Interaction logic for MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        // The folllowing method retrieves the name of the currently active window.
        private string GetActiveWindowName()
        {
            var activeWindow = Application.Current.Windows
                .OfType<Window>()
                .FirstOrDefault(w => w.IsActive);

            return activeWindow?.GetType().Name ?? "";
        }

        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Employee management is not implemented yet.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            if (GetActiveWindowName() != "MainMenuWindow")
            {
                MainMenuWindow dashboardWindow = new MainMenuWindow();
                dashboardWindow.Show();
                this.Close(); // Close current window
            }
            else
            {
                MessageBox.Show("You are already on the dashboard.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void WarehouseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Warehouse management is not implemented yet.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order management is not implemented yet.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TransportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Transport management is not implemented yet.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ReportsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Report generation is not implemented yet.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (SideMenu.Visibility == Visibility.Visible)
            {
                SideMenu.Visibility = Visibility.Collapsed; // Hide the side menu
            }
            else
            {
                SideMenu.Visibility = Visibility.Visible; // Show the side menu
            }
        }
    }
}
