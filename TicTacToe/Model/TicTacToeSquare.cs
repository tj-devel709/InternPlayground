using TicTacToe.Model;

namespace TicTacToe.ViewModel;

public class TicTacToeSquare : BaseViewModel
{
    string _position;
    bool alreadyClicked = false;
    public Command Clicked { get; }
    public event EventHandler OnSquareClicked;

    public TicTacToeSquare(string position)
    {
        Clicked = new Command(OnClicked, () => String.IsNullOrWhiteSpace(_text));
    }

    string _text;
    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            OnPropertyChanged();
        }
    }

    void OnClicked()
    {
        OnSquareClicked?.Invoke();
    }

    public void SetToX()
    {
        Text = "X";
        Clicked.ChangeCanExecute();
    }

    public void SetToY()
    {
        Text = "Y";
        Clicked.ChangeCanExecute();
    }
}