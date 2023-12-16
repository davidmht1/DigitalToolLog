using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalToolLog.Models
{
    public partial class ToolLog : ObservableObject
    {
        [Key]
        public int logEntryId;

        [ObservableProperty]
        private string time = string.Empty;

        [ObservableProperty]
        private string date = string.Empty;

        [ObservableProperty]
        private Employee? employee;

        [ObservableProperty]
        private Toolbox? toolbox;

        private ObservableCollection<Employee> employeeCollection = new();

        private ObservableCollection<Toolbox> toolboxCollection = new();
    }
}
