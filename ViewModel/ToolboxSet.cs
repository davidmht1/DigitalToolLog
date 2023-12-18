using CommunityToolkit.Mvvm.ComponentModel;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DigitalToolLog.ViewModel
{
    public partial class ToolboxSet: ObservableObject
    {
        [ObservableProperty]
        public Toolbox? selectedToolBox;
        public ObservableCollection<Toolbox>? ToolboxList { get; set; }

        public ToolboxSet(bool all)
        {
            if(all)
                ToolboxList = new ObservableCollection<Toolbox>(Db.Service().GetToolboxes());
            else
                ToolboxList = new ObservableCollection<Toolbox>(Db.Service().AvailableToolboxes());
        }
    }
}
