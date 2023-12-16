using DigitalToolLog.ViewModel;

namespace DigitalToolLog.Views;

public partial class ToolLogView : ContentPage
{
	public ToolLogEntry? Entry { get; }
	public ToolLogView()
	{
		Entry = new();
		BindingContext = this;
		InitializeComponent();
	}
}