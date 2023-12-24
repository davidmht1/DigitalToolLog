using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class EditToolbox : ContentPage
{
	public EditToolbox(ToolboxEntry entry)
	{
		BindingContext = entry;
		InitializeComponent();
	}
}