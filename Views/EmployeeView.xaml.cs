using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class EmployeeView : ContentPage
{
    EmployeeEntry Model;
    public EmployeeView()
	{
        Model = new EmployeeEntry();
        BindingContext = Model;
        InitializeComponent();
    }

    private async void Edit(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditEmployee(Model));
    }
}