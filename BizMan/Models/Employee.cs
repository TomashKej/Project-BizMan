using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizMan.Models
{
    /// <summary>
    ///  class representing an employee in the business management system.
    ///  store various details about the employee such as name, position, department, and contact information.
    ///  class represents a data from employee database or a similar data source.
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // Event to notify when a property value changes
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // Raise the PropertyChanged event
        }
        // Properties of the Employee class

        private int id;
        private string firstName;
        private string lastName;
        private string position;
        private string department;
        private DateTime hireDate;
        private decimal salary;
        private string email;
        private string phoneNumber;
        private string address;
        private string city;
        private string county;
        private string postCode;
        private string country;
        private DateTime dateOfBirth;

        public int ID
        { 
            get => id;
            set { id = value; OnPropertyChanged(nameof(ID)); }
        }
        public string FirstName 
        {
            get => firstName;
            set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }
        public string LastName 
        {
            get => lastName;
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        } 
        public string Position 
        {
            get => position;
            set { position = value; OnPropertyChanged(nameof(Position)); }
        }
        public string Department 
        {
            get => department;
            set { department = value; OnPropertyChanged(nameof(Department)); }
        } 
        public DateTime HireDate 
        {
            get => hireDate;
            set { hireDate = value; OnPropertyChanged(nameof(HireDate)); }
        } 
        public decimal Salary 
        {
            get => salary;
            set { salary = value; OnPropertyChanged(nameof(Salary)); }
        }
        public string Email 
        {
            get => email;
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }
        public string PhoneNumber 
        {
            get => phoneNumber;
            set { phoneNumber = value; OnPropertyChanged(nameof(PhoneNumber)); }
        }
        public string Address 
        {
            get => address;
            set { address = value; OnPropertyChanged(nameof(Address)); }
        } 
        public string City 
        {
            get => city;
            set { city = value; OnPropertyChanged(nameof(City)); }
        }
        public string County 
        {
            get => county;
            set { county = value; OnPropertyChanged(nameof(County)); }
        }
        public string PostCode 
        {
            get => postCode;
            set { postCode = value; OnPropertyChanged(nameof(PostCode)); }
        }
        public string Country 
        {
            get => country;
            set { country = value; OnPropertyChanged(nameof(Country)); }
        }
        public DateTime DateOfBirth 
        {
            get => dateOfBirth;
            set { dateOfBirth = value; OnPropertyChanged(nameof(DateOfBirth)); }
        }
    }
}
