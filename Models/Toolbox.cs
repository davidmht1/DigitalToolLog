using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DigitalToolLog.Models
{
    [Index(nameof(Identifier), IsUnique = true)]
    public partial class Toolbox : ObservableObject
    {
        [Key]
        public int Id;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string identifier = string.Empty;

        [ObservableProperty]
        private bool isCheckedOut = false;
    }
}
