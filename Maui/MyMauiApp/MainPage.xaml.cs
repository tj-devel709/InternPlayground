namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	int Rotation = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count += 5;
		Rotation += 90;
		
		if (count <= 100) {
			CounterBtn.Text = $"Clicked {count} times";
			Bot.RotateTo(Rotation);
		}
		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

