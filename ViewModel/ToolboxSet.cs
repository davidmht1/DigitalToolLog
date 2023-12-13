using CommunityToolkit.Mvvm.ComponentModel;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;

namespace DigitalToolLog.ViewModel
{
    public partial class ToolboxSet: ObservableObject
    {
        public ObservableCollection<Toolbox> ToolboxList { get; set; }

        public ToolboxSet()
        {
            ToolboxList = new ObservableCollection<Toolbox>(Db.Service().GetToolboxes());
        }

    }
}
