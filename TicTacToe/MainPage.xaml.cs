namespace TicTacToe;

public partial class MainPage : ContentPage
{
	int count = 0, position = 0;
	static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7','8' };

	public MainPage()
	{
		InitializeComponent();
	}

	// This is the Event Handler for the TopLeftButton Press
	void TopLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 0;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 0;
			arr[position] = '0';
			count++;
		}
	}
	void TopCenterBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 1;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 1;
			arr[position] = '0';
			count++;
		}
	}

	void TopRightBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 2;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 2;
			arr[position] = '0';
			count++;
		}
	}

	void CenterLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 3;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 3;
			arr[position] = '0';
			count++;
		}
	}

	void CenterCenterBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 4;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 4;
			arr[position] = '0';
			count++;
		}
	}

	void CenterRightBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 5;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 5;
			arr[position] = '0';
			count++;
		}
	}

	void BottomLeftBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 6;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 6;
			arr[position] = '0';
			count++;
		}
	}

	void BottomCenterBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 7;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 7;
			arr[position] = '0';
			count++;
		}
	}

	void BottomRightBtn_Pressed(System.Object sender, System.EventArgs e)
	{
		if (count % 2 == 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "X";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 8;
			arr[position] = 'X';
			count++;
		}

		else if (count % 2 != 0 && count < 9)
		{
			var btn = sender as Button;
			btn.Text = "0";
			btn.TextColor = Colors.Black;
			btn.FontSize = 84;
			position = 8;
			arr[position] = '0';
			count++;
		}
	}

}
