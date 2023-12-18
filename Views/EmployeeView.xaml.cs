using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class EmployeeView : ContentPage
{
    public EmployeeView(EmployeeEntry empVM)
	{
        BindingContext = empVM;
        InitializeComponent();
    }
}