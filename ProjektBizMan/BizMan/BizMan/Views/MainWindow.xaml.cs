using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using BizMan.DataBase;
using BizMan.Models;
using BizMan.ViewModels;

namespace BizMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeViewModel viewModel; // ViewModel to manage employee data

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new EmployeeViewModel(); // Initialize the ViewModel
            this.DataContext = viewModel; // Set the DataContext of the window to the ViewModel

            using var db = new AppDbContext();
            // db.Database.EnsureDeleted();  //Deletes database
            db.Database.EnsureCreated(); // Ensures that the database is created if it does not exist.

            // Check if the Employees table is empty, and if so, you can seed it with initial data.
            if (!db.Employees.Any())
            {
                // Add a default employee if the Employees table is empty.
                db.Employees.Add(new Employee
                {
                    ID = 174558,
                    FirstName = "John",
                    LastName = "Doe",
                    Department = "Not Specified",
                    Position = "Not Specified",
                    HireDate = DateTime.Now,
                    Salary = 0.0m,
                    Email = "Not Specified",
                    PhoneNumber = "Not Specified",
                    Address = "Not Specified",
                    City = "Not Specified",
                    County = "Not Specified",
                    PostCode = "Not Specified",
                    Country = "Not Specified",
                    DateOfBirth = DateTime.Now
                });
                db.SaveChanges(); // Save changes to the database
            }

            viewModel.Employees.Clear();
            foreach (var emp in db.Employees)
            {
                viewModel.Employees.Add(emp); // Load employees from the database into the ViewModel
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var newEmployee = new Employee(); // Create a new employee instance
            // Create a new window for adding a new employee
            AddEmployeeWindow addWindow = new AddEmployeeWindow(newEmployee);
            if (addWindow.ShowDialog() == true)
            {
                // If the dialog result is true, add the new employee to the ViewModel and database
                viewModel.addEmployee(newEmployee);
                using var db = new AppDbContext();
                db.Employees.Add(newEmployee); // Add the new employee to the database
                db.SaveChanges(); // Save changes to the database
                
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeListView.SelectedItem is Employee selected)
            { 
                viewModel.removeEmployee(selected); // Remove the selected employee from the ViewModel
                using var db = new AppDbContext();
                db.Employees.Remove(selected); // Remove the employee from the database
                db.SaveChanges(); // Save changes to the database
            }
            else
            {
                MessageBox.Show("Please select an employee record to delete.");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeListView.SelectedItem is Employee selected)
            {
                // Create a new window for editing the selected employee
                EditEmployeeWindow editWindow = new EditEmployeeWindow(selected);
                if (editWindow.ShowDialog() == true)
                {
                    // If the dialog result is true, update the employee in the ViewModel and database
                    viewModel.editEmployee(selected, editWindow.UpdatedEmployee);
                    using var db = new AppDbContext();
                    db.Employees.Update(editWindow.UpdatedEmployee); // Update the employee in the database
                    db.SaveChanges(); // Save changes to the database
                }
            }
            else
            {
                MessageBox.Show("Please select an employee record to edit.");
            }
        }
    }
}