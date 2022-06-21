namespace TicTacToe;

public partial class MainPage : ContentPage
{

	Board gameBoard;
	bool isFirstPlayer = true;

	public MainPage()
	{
		InitializeComponent();
		gameBoard = new Board ();
	}

    void AssignMarker(object sender, int row, int col)
    {
        var btn = sender as Button;

        btn.FontSize = 84;

        var marker = gameBoard.AddMove(row, col, isFirstPlayer);

        if (marker != default(char))
        {
            btn.Text = marker.ToString();
            btn.TextColor = isFirstPlayer ? Colors.Black : Colors.Red;
            isFirstPlayer = !isFirstPlayer;
        }

        if (gameBoard.CheckWin ())
            DisplayAlert ("Congrats!", "You won!", "Reset");
    }

    void TopLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
        AssignMarker (sender, 0, 0);
	}

    void TopCenterBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 0, 1);
    }

    void TopRightBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 0, 2);
    }

    void CenterLeftBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 1, 0);
    }

    void CenterCenterBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 1, 1);
    }

    void CenterRightBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 1, 2);
    }

    void BottomLeftBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 2, 0);
    }

    void BottomCenterBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 2, 1);
    }

    void BottomRightBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        AssignMarker(sender, 2, 2);
    }

    void ResetBtn_Pressed(System.Object sender, System.EventArgs e)
    {
        gameBoard.EraseBoard ();

        //TopLeftBtn.Text = TopCenterBtn.Text = TopRightBtn.Text
        //    = CenterLeftBtn.Text = CenterCenterBtn.Text = CenterRightBtn.Text
        //    = BottomLeftBtn.Text = BottomCenterBtn.Text = BottomRightBtn.Text = String.Empty;

        TopLeftBtn.Text = String.Empty;
        TopCenterBtn.Text = String.Empty;
        TopRightBtn.Text = String.Empty;
        CenterLeftBtn.Text = String.Empty;
        CenterCenterBtn.Text = String.Empty;
        CenterRightBtn.Text = String.Empty;
        BottomLeftBtn.Text = String.Empty;
        BottomCenterBtn.Text = String.Empty;
        BottomRightBtn.Text = String.Empty;

        isFirstPlayer = true;
    }
}
