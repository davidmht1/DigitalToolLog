using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalToolLog.Models
{
    public partial class Employee: ObservableObject
    {
        [Key]
        public int Id;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private int employeeNumber;
    }
}
