using BizMan.Models;
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
    /// Interaction logic for EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window
    {

        public Employee UpdatedEmployee { get; private set; }
        public EditEmployeeWindow(Employee employee)
        {
            InitializeComponent();

            UpdatedEmployee = new Employee
            {
                ID = employee.ID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Position = employee.Position,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                Address = employee.Address,
                City = employee.City,
                County = employee.County,
                PostCode = employee.PostCode,
                Country = employee.Country,
                DateOfBirth = employee.DateOfBirth
            };

            this.DataContext = UpdatedEmployee; // Set the DataContext of the window to the updated employee
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
