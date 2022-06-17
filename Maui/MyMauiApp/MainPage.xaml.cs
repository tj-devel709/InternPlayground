namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0, count2 = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count += 5;

		if (count <= 100)
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnCounterClicked2(object sender, EventArgs e)
	{
		count2++;

		if (count2 == 1)
		{
			CounterBtn2.Text = $"No Functionality";
		}
		else
		{
			CounterBtn2.Text = $"No Functionality";

		}

		SemanticScreenReader.Announce(CounterBtn2.Text);

	}

}

