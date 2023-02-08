using System.Diagnostics;
using _2lz.Pages;

namespace _2lz;

public partial class MainPage : ContentPage
{
	private const string PROJECT_GIT_URL = "https://github.com/arrrky/2lz";

    public MainPage()
	{
		InitializeComponent();
	}	

    private void OnGitLinkButton_Clicked(object sender, EventArgs e)
    {
		try
		{
            Browser.Default.OpenAsync(PROJECT_GIT_URL);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    private async void OnPushSenderButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync<PushSenderPage>();
    }
}