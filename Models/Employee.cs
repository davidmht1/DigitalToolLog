using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DigitalToolLog.Models
{
    public partial class Employee: ObservableObject
    {
        [Key]
        public int Id;

        [ObservableProperty]
        public string name = string.Empty;

        [ObservableProperty]
        public int employeeNumber;
    }
}
