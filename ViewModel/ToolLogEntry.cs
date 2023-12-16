using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DigitalToolLog.Models;

namespace DigitalToolLog.ViewModel
{
    public partial class ToolLogEntry: ObservableObject
    {
        [ObservableProperty]
        public ToolLog? checkout;

        [ObservableProperty]
        public EmployeeSet employeeSet;

        [ObservableProperty]
        public ToolboxSet toolboxSet;

        [ObservableProperty]
        public ToolLogSet toolLogSet;

        public ToolLogEntry()
        {
            employeeSet = new EmployeeSet();
            toolboxSet = new ToolboxSet();
            toolLogSet = new ToolLogSet();
        }

        [RelayCommand]
        public void AssignTool()
        {
            Checkout = new ToolLog()
            {
                Toolbox = ToolboxSet.SelectedToolBox,
                Employee = EmployeeSet.SelectedEmployee
            };


        }
    }
}
