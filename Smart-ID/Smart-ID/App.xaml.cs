using Smart_ID.Views.RecordPages;

namespace Smart_ID;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
    }
}
