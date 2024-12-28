using Plugin.Maui.ScreenRecording;

namespace TestProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            ScreenRecording.Default.StartRecording();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            ScreenRecording.Default.StopRecording();
            AppShell.Current.Navigation.PushAsync(new MediaPage());
        }
    }

}
