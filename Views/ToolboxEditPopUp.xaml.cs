using CommunityToolkit.Maui.Views;
using DigitalToolLog.Models;
using DigitalToolLog.Service;

namespace DigitalToolLog.Views;

public partial class ToolboxEditPopUp : Popup
{
    Toolbox toolbox;
	public ToolboxEditPopUp(Toolbox box)
    {
        toolbox = box;
        BindingContext = toolbox;
		InitializeComponent();
	}

    async void Save(object? sender, EventArgs e)
	{
        Db.Service().Update(toolbox);
        await CloseAsync(true);
    }

    async void Close(object? sender, EventArgs e)
	{
        await CloseAsync(false);
    }
}