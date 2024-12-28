namespace TestProject;

public partial class MediaPage : ContentPage
{
	public MediaPage()
	{
		InitializeComponent();
	}

    private void ContentPage_Unloaded(object sender, EventArgs e)
    {
		MediaElement.Handler?.DisconnectHandler();
    }
}