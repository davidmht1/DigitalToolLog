using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class EditEmployee : ContentPage
{
	public EditEmployee(EmployeeEntry entry)
	{
		BindingContext = entry;
		InitializeComponent();
	}
}