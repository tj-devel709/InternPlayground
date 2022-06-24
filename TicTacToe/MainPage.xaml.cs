
namespace TicTacToe;

public partial class MainPage : ContentPage
{
	int count = 0, position = 0;
	static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7','8' };

	public MainPage()
	{
		InitializeComponent();
		WinnerProperty = "Something..";
		//TopCenterBtn.Text = "Player 1";
	}

	// TODO: Rachel help figure out bindings

	// This is the Event Handler for the TopLeftButton Press
	void TopLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	
	private string winnerProperty;
	public string WinnerProperty

	{
		get { return winnerProperty; }
		set
		{
			winnerProperty = value;
			OnPropertyChanged(nameof(WinnerProperty));
		}
	}

	// This is the Event Handler for the TopLeftButton Press
	void TopLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 0;
		ButtonEvents(sender, e, count, position);
		count++;
	}
	void TopCenterBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 1;
		ButtonEvents(sender, e, count, position);
		count++;
	}

	void TopRightBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 2;
		ButtonEvents(sender, e, count, position);
		count++;
	}

	void CenterLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 3;
		ButtonEvents(sender, e, count, position);
		count++;
	}

	void CenterCenterBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 4;
		ButtonEvents(sender, e, count, position);
		count++;
	}

	void CenterRightBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 5;
		ButtonEvents(sender, e, count, position);
		count++;
	
	}

	void BottomLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 6;
		ButtonEvents(sender, e, count, position);
		count++;
	}

	void BottomCenterBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 7;
		ButtonEvents(sender, e, count, position);
		count++;
	}

	void BottomRightBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		position = 8; 
		ButtonEvents(sender, e, count, position);
		count++;
	}

	
	public void ButtonEvents(System.Object sender, System.EventArgs e, int count, int position){
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			arr[position] = 'X';
			WhoWon(count);
			btn.IsEnabled = false;

		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			arr[position] = '0';
			WhoWon(count);
			btn.IsEnabled = false;
		}
	}
	

	public void WhoWon(int count)
   {
		HorizontalWin(count);
		VerticalWin(count);
		DiagonalWin(count);
		
	}

	public void HorizontalWin(int count){
		if ((arr[0] == arr[1] && arr[1] == arr[2]) || (arr[3] == arr[4] && arr[4] == arr[5]) || (arr[6] == arr[7] && arr[7] == arr[8])){
			Player(count);
		}
	}
	public void VerticalWin(int count){
		if ((arr[0] == arr[3] && arr[4] == arr[6]) || (arr[1] == arr[4] && arr[4] == arr[7]) || (arr[2] == arr[5] && arr[5] == arr[8])){
			Player(count);
		}
	}
	public void DiagonalWin(int count){
		if((arr[0] == arr[4] && arr[4] == arr[8]) || (arr[2] == arr[4] && arr[4] == arr[6])){
			Player(count);
		}
	}

	public void Player(int count)
	{
		// TopCenterBtn.Text = "Player TJ";
		
		if (count % 2 == 0) {
			WinnerProperty = "Player 1 won"!;
		}
		else {
			WinnerProperty = "Player 2 won!";
		}
	}

}
/**
 * 
 * arr[0] arr[1] arr[2]
 * 
 * arr[3] arr[4] arr[5]
 * 
 * arr[6] arr[7] arr[8]
 * 
 */
