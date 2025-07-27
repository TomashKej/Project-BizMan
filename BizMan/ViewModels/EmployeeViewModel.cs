using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BizMan.Models;

namespace BizMan.ViewModels
{
    public class EmployeeViewModel
    {
        // Employee colection to view in the UI
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            // Initialize the Employees collection
            Employees = new ObservableCollection<Employee>();
        }
    
    // The following methods are used to manage the employee collection
        // Method to add a new employee to the collection
        public void addEmployee(Employee employee)
        {
            if (employee != null)
            {
                Employees.Add(employee);
            }
        }

        // Method to remove an employee from the collection
        public void removeEmployee(Employee employee)
        {
            if (employee != null)
            { 
                Employees.Remove(employee);
            }
        }

        // Method to edit an existing employee in the collection
        public void editEmployee(Employee original, Employee updated)
        {
            if (original != null && updated != null)
            {
                original.ID = updated.ID;
                original.FirstName = updated.FirstName;
                original.LastName = updated.LastName;
                original.Position = updated.Position;
                original.Department = updated.Department;
                original.Email = updated.Email;
                original.PhoneNumber = updated.PhoneNumber;
                original.HireDate = updated.HireDate;
                original.Salary = updated.Salary;
                original.Address = updated.Address;
                original.City = updated.City;
                original.County = updated.County;
                original.PostCode = updated.PostCode;
                original.Country = updated.Country;
                original.DateOfBirth = updated.DateOfBirth;
            }
        }
    }
}
