using CommunityToolkit.Mvvm.ComponentModel;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;

namespace DigitalToolLog.ViewModel
{
    public partial class EmployeeSet: ObservableObject
    {

        [ObservableProperty]
        public Employee? selectedEmployee;

        public ObservableCollection<Employee> EmployeeList { get; set; }
        
        public EmployeeSet()
        {
            EmployeeList = new ObservableCollection<Employee>(Db.Service().GetEmployees());
        }
    }
}
