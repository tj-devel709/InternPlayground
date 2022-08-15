using TicTacToe.ViewModel;

namespace TicTacToe;

public partial class MainPage : ContentPage
{
	TicTacToeViewModel _viewModel;

    int count = 0, position = 0;

	public MainPage()
	{
		InitializeComponent();
        BindingContext = _viewModel = new TicTacToeViewModel();
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
			_viewModel.UpdateArray('X', position);
			_viewModel.WhoWon(count);
			btn.IsEnabled = false;

		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
            _viewModel.UpdateArray('O', position);
            _viewModel.WhoWon(count);
			btn.IsEnabled = false;
		}
	}
}
