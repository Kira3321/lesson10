namespace Lesson10;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void MainPageMainButtonClickedTask1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new task_1());
    }

    private async void MainPageMainButtonClickedTask2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new task_2());
    }
}

