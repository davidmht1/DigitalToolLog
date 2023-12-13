using DigitalToolLog.Service;
using DigitalToolLog.ViewModel;
using DigitalToolLog.Views;
using Microsoft.Extensions.Logging;

namespace DigitalToolLog
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<EmployeeView>();
            builder.Services.AddSingleton<EmployeeEntry>();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
