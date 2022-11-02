
using System.Collections.ObjectModel;

namespace Lesson10;

public partial class task_1 : ContentPage
{
	public task_1()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(EntryText.Text))
            foreach (var item in EntryText.Text.Split(" "))
            {
                if(!String.IsNullOrWhiteSpace(item)) ResultView.Results.Add(item);
            }
            EntryText.Text = "";
    }
}

public static class ResultView
{
    public static ObservableCollection<string> Results { get; set; }

    static ResultView()
    {
        Results = new ObservableCollection<string>();
    }
}