using DigitalToolLog.ViewModel;
using System.Security.Cryptography.X509Certificates;

namespace DigitalToolLog.Views;

public partial class ToolboxView : ContentPage
{
	public ToolboxView(ToolboxEntry boxVM)
	{
		BindingContext = boxVM;
		InitializeComponent();
	}
}