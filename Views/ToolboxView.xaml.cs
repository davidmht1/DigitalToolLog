using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class ToolboxView : ContentPage
{
    ToolboxEntry Model;
    public ToolboxView()
    {
        Model = new ToolboxEntry();
        BindingContext = Model;
        InitializeComponent();
    }
    private async void Edit(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditToolbox(Model));

    }
}