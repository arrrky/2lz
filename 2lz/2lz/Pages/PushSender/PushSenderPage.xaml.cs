using _2lz.PushSender;
using _2lz.Pages.PushSender;

namespace _2lz.Pages;

public partial class PushSenderPage : ContentPage
{
    private readonly IPushSender _pushSender;

    public PushSenderPage(IPushSender pushSender)
    {
        InitializeComponent();

        _pushSender = pushSender;
    }

    #region Button Clicked Handlers

    private void OnSendButton_Clicked(object sender, EventArgs e)
    {
        _pushSender.SendPush();
    }

    private async void OnAddServerButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync<AddServerPage>();
    }

    private async void OnAddAppButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync<AddAppPage>();
    }

    #endregion
}