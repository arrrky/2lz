using System.Diagnostics;

namespace _2lz;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
        SetWindow();
    }

    [Conditional("MACCATALYST")]
    private void SetWindow()
    {        
        // https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/windows?view=net-maui-7.0#mac-catalyst
        // Разобраться, как реализовать + по возможности объединить с WINDOWS логикой
    }

#if WINDOWS    

    // DeviceDisplay.Current.MainDisplayInfo по какой-то причине не работает (все поля и свойства нулевые)
    // Поэтому пока константы - разобраться
    private const int WINDOW_HEIGHT = 700;
    private const int WINDOW_WIDTH = 500;

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);       

        window.Height = WINDOW_HEIGHT;
        window.Width = WINDOW_WIDTH;

        return window;
    }   

#endif
}