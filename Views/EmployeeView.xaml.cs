using CommunityToolkit.Mvvm.ComponentModel;
using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class EmployeeView : ContentPage
{
	public EmployeeEntry Entry { get; set; }

    public EmployeeView()
	{
        Entry = new();
        BindingContext = this;
        InitializeComponent();
    }
}