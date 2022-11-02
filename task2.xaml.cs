namespace Lesson10;

public partial class task_2 : ContentPage
{
	public task_2()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        LB.Text = ReverseStringArrayToString(EntryText.Text.Split());
        EntryText.Text = "";
    }

    private string ReverseStringArrayToString(string[] arg)
    {
        var result = new string[arg.Length];
        for (int i = 0; i < arg.Length; i++)
            result[i] = arg[arg.Length - i - 1];
        return String.Join(" ", result);
    }
}