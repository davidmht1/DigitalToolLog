using CommunityToolkit.Mvvm.ComponentModel;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;

namespace DigitalToolLog.ViewModel
{
    public partial class ToolLogSet : ObservableObject
    {
        public ObservableCollection<ToolLog> ToolLogEntries { get; set; }
        
        public ToolLogSet()
        {
            ToolLogEntries = new ObservableCollection<ToolLog>(Db.Service().GetToolLog());
        }
}
}
