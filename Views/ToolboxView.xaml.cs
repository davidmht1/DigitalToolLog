using CommunityToolkit.Maui.Views;
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

    private async void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        if(Model.SetModel.SelectedToolBox != null)
        {
            //replace with navigation push and pop
            var popup = new ToolboxEditPopUp(Model.SetModel.SelectedToolBox);
            var result = await this.ShowPopupAsync(popup, CancellationToken.None);
        }
    }
}