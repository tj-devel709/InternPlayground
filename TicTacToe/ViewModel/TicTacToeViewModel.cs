using TicTacToe.Model;

namespace TicTacToe.ViewModel;

public class TicTacToeViewModel : BaseViewModel
{
    public TicTacToeViewModel()
    {
    }

    public TicTacToeBoard BoardViewModel { get; } = new TicTacToeBoard();
    public char[] BoardPositions = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

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

    public void Player(int count)
    {
        if (count % 2 == 0)
        {
            WinnerProperty = "Player 1 won!";
        }
        else
        {
            WinnerProperty = "Player 2 won!";
        }
    }

    public void UpdateArray(char mark, int position)
    {
        arr[position] = mark;
    }

    public void WhoWon(int count)
    {
        HorizontalWin(count);
        VerticalWin(count);
        DiagonalWin(count);
    }

    public void HorizontalWin(int count)
    {
        if ((arr[0] == arr[1] && arr[1] == arr[2]) || (arr[3] == arr[4] && arr[4] == arr[5]) || (arr[6] == arr[7] && arr[7] == arr[8]))
        {
            Player(count);
        }
    }

    public void VerticalWin(int count)
    {
        if ((arr[0] == arr[3] && arr[4] == arr[6]) || (arr[1] == arr[4] && arr[4] == arr[7]) || (arr[2] == arr[5] && arr[5] == arr[8]))
        {
            Player(count);
        }
    }

    public void DiagonalWin(int count)
    {
        if ((arr[0] == arr[4] && arr[4] == arr[8]) || (arr[2] == arr[4] && arr[4] == arr[6]))
        {
            Player(count);
        }
    }
}
