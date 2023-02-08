using _2lz.PushSender;

namespace _2lz.Pages;

public partial class PushSenderPage : ContentPage
{
    private readonly IPushSender _pushSender;

    public PushSenderPage(IPushSender pushSender)
    {
        InitializeComponent();      

        _pushSender = pushSender;
    }

    private void OnSendButton_Clicked(object sender, EventArgs e)
    {
        _pushSender.SendPush();
    }
}