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

using BizMan.Models;

namespace BizMan
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public Employee newEmployee { get; private set; }
        public AddEmployeeWindow(Employee employee)
        {
            InitializeComponent();
            newEmployee = employee; // Assign the passed employee to the newEmployee property
            this.DataContext = newEmployee; // Set the DataContext of the window to the new employee
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        { 
            DialogResult = true; // Set the dialog result to true to indicate that the employee was saved
            Close(); // Close the window
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Set the dialog result to false to indicate that the employee was not saved
            Close(); // Close the window
        }
    }
}
