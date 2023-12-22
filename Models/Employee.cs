using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DigitalToolLog.Models
{
    [Index(nameof(EmployeeNumber), IsUnique = true)]
    public partial class Employee : ObservableObject
    {
        [Key]
        public int Id;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private int employeeNumber;
    }
}
