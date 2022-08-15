namespace TicTacToe.ViewModel;

public class TicTacToeBoard : BaseViewModel
{
    int count = 0, position = 0;
    public char[] BoardPositions = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
    public TicTacToeBoard()
    {
        TopLeftSquare = new TicTacToeSquare("1");
        TopLeftSquare.OnSquareClicked += OnSquareClicked;
    }

    public void OnSquareClicked(object sender, EventArgs args)
    {
        if (sender is TicTacToeSquare square)
        {
            square.SetToX();
        }
    }

    public TicTacToeSquare TopLeftSquare { get; set; }
}
