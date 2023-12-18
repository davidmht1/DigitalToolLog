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

        bool allBoxes = false;
        public ObservableCollection<string> Message { get; } = new();

        public ToolLogEntry()
        {
            employeeSet = new EmployeeSet();
            toolboxSet = new ToolboxSet(allBoxes);
            toolLogSet = new ToolLogSet();
        }

        [RelayCommand]
        public void PageLoading()
        {
            //needs optimizing 
            foreach(var employee in Db.Service().GetEmployees())
            {
                if(!employeeSet.EmployeeList.Contains(employee))
                {
                    employeeSet.EmployeeList.Add(employee);
                }
            }

            foreach (var toolbox in Db.Service().AvailableToolboxes())
            {
                if (!toolboxSet.ToolboxList.Contains(toolbox))
                {
                    toolboxSet.ToolboxList.Add(toolbox);
                }
            }
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
                var box = ToolboxSet.SelectedToolBox;

                Checkout = new ToolLog()
                {
                    Toolbox = box,
                    Employee = EmployeeSet.SelectedEmployee
                };

                box.IsCheckedOut = true;
                Db.Service().Update(box);
                
                Db.Service().Add(Checkout);
                ToolLogSet.ToolLogEntries.Add(Checkout);

                ToolboxSet.ToolboxList.Remove(box);
            }
        }
    }
}
