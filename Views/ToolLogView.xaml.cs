using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class ToolLogView : ContentPage
{
	public ToolLogView(ToolLogEntry logVM)
	{
		BindingContext = logVM;
		InitializeComponent();
	}
}