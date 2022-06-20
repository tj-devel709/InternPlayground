namespace TicTacToe;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	// This is the Event Handler for the TopLeftButton Press
	void TopLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		var btn = sender as Button;
		btn.Text = "X";
		btn.TextColor = Colors.Black;
		btn.FontSize = 84;
	}
}
