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
        // TODO
    }

#if WINDOWS    

    // DeviceDisplay.Current.MainDisplayInfo doesn't work for some reason (all properties and field are zero)
    // WTF?
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