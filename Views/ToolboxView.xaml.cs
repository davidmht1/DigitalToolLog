using DigitalToolLog.ViewModel;
using System.Security.Cryptography.X509Certificates;

namespace DigitalToolLog.Views;

public partial class ToolboxView : ContentPage
{
	public ToolboxEntry Entry { get; set; }
	public ToolboxView()
	{
		Entry = new();
		BindingContext = this;
		InitializeComponent();
	}
}