using System;
namespace TicTacToe
{
	public class Board
	{
		public char[,] BoardArray { get; set; }

		public Board ()
		{
			BoardArray = new char[3, 3];
		}

		public char AddMove (int row, int col, bool isFirstPlayer)
		{
			if (BoardArray[row, col] != default(char))
				return default(char);

			// called "ternary conditional operator"
			var marker = isFirstPlayer ? 'X' : 'O';

			BoardArray[row, col] = marker;
			return marker;
		}

		public bool CheckWin ()
        {
			var isXWin = CheckWin ('X');
			var isOWin = CheckWin ('O');
			return isXWin || isOWin;
        }

		bool CheckWin (char marker)
        {
			if ((BoardArray[0, 0] == marker && BoardArray[0, 1] == marker && BoardArray[0, 2] == marker)
				|| (BoardArray[1, 0] == marker && BoardArray[1, 1] == marker && BoardArray[1, 2] == marker)
				|| (BoardArray[2, 0] == marker && BoardArray[2, 1] == marker && BoardArray[2, 2] == marker)
				|| (BoardArray[0, 0] == marker && BoardArray[1, 0] == marker && BoardArray[2, 0] == marker)
				|| (BoardArray[0, 1] == marker && BoardArray[1, 1] == marker && BoardArray[2, 1] == marker)
				|| (BoardArray[0, 2] == marker && BoardArray[1, 2] == marker && BoardArray[2, 2] == marker)
				|| (BoardArray[0, 0] == marker && BoardArray[1, 1] == marker && BoardArray[2, 2] == marker)
				|| (BoardArray[0, 2] == marker && BoardArray[1, 1] == marker && BoardArray[2, 0] == marker))
			{
				return true;
			}

			return false;
		}

		public void EraseBoard ()
        {
			BoardArray = new char[3, 3];
		}
	}
}

