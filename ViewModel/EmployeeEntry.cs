using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;

namespace DigitalToolLog.ViewModel
{
    public partial class EmployeeEntry : ObservableObject
    {
        [ObservableProperty]
        public Employee employee;

        [ObservableProperty]
        public EmployeeSet setModel;

        public ObservableCollection<string> Message { get; } = new();
        
        public EmployeeEntry()
        {
            employee = new Employee();
            setModel = new EmployeeSet();
        }

        [RelayCommand]
        public void SaveEmployee()
        {
            Message.Clear();

            if (Employee.EmployeeNumber == 0)
            {
                Message.Add("Employee Number is Empty.");
            }
            if (Employee.Name == string.Empty)
            {
                Message.Add("Enter Employee Name.");
            }

            if (Message.Count == 0)
            {
                try
                {
                    Db.Service().Add(Employee);
                    SetModel.EmployeeList.Add(Employee);
                    Message.Add($"{Employee.Name} added succesfully.");

                    Employee = new();

                }
                catch(Exception ex)
                {
                    Message.Add(ex.Message);
                }
            }
        }
    }
}
