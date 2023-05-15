using Microsoft.Extensions.Logging;
using _2lz.PushSender;
using _2lz.Pages;
using _2lz.Pages.PushSender;

namespace _2lz;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .RegisterAppServices()
            .RegisterAppPages()
            .UsePageResolver()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IPushSender, PushSender.PushSender>();
        return builder;
    }

    public static MauiAppBuilder RegisterAppPages(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<PushSenderPage>();
        builder.Services.AddTransient<AddAppPage>();
        builder.Services.AddTransient<AddServerPage>();
        return builder;
    }
}