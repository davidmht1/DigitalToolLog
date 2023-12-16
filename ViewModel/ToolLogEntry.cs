using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;

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

        public ObservableCollection<string> Message { get; } = new();

        public ToolLogEntry()
        {
            employeeSet = new EmployeeSet();
            toolboxSet = new ToolboxSet();
            toolLogSet = new ToolLogSet();
        }

        [RelayCommand]
        public void AssignTool()
        {
            Message.Clear();

            if(EmployeeSet.SelectedEmployee == null)
            {
                Message.Add("No Employee Selected");
            }
            if(ToolboxSet.SelectedToolBox == null)
            {
                Message.Add("No Toolbox Selected");
            }

            if(Message.Count() == 0)
            {
                Checkout = new ToolLog()
                {
                    Toolbox = ToolboxSet.SelectedToolBox,
                    Employee = EmployeeSet.SelectedEmployee
                };
                
                Db.Service().Add(Checkout);
                ToolLogSet.ToolLogEntries.Add(Checkout);
            }
        }
    }
}
