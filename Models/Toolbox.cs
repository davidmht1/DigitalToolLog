using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalToolLog.Models
{
    public partial class Toolbox: ObservableObject
    {
        [Key]
        public int Id;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string identifier = string.Empty;
        
    }
}
