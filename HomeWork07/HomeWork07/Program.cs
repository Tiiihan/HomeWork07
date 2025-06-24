bool isGameOver = false;
bool isEndX = false;
bool isEndO = false;
string playerX = "";
string playerO = "";

string c1 = "1";
string c2 = "2";
string c3 = "3";
string c4 = "4";
string c5 = "5";
string c6 = "6";
string c7 = "7";
string c8 = "8";
string c9 = "9";

//Winning combinations
#region
//1,2,3
bool xWin1 = c1 == "X" && c2 == "X" && c3 == "X";
//4,5,6
bool xWin2 = c4 == "X" && c5 == "X" && c6 == "X";
//7,8,9
bool xWin3 = c7 == "X" && c8 == "X" && c9 == "X";
//1,4,7
bool xWin4 = c1 == "X" && c4 == "X" && c7 == "X";
//2,5,8
bool xWin5 = c2 == "X" && c5 == "X" && c8 == "X";
//3,6,9
bool xWin6 = c3 == "X" && c6 == "X" && c9 == "X";
//1,5,9
bool xWin7 = c1 == "X" && c5 == "X" && c9 == "X";
//3,5,7
bool xWin8 = c7 == "X" && c5 == "X" && c3 == "X";


//1,2,3
bool oWin1 = c1 == "O" && c2 == "O" && c3 == "O";
//4,5,6
bool oWin2 = c4 == "O" && c5 == "O" && c6 == "O";
//7,8,9
bool oWin3 = c7 == "O" && c8 == "O" && c9 == "O";
//1,4,7
bool oWin4 = c1 == "O" && c4 == "O" && c7 == "O";
//2,5,8
bool oWin5 = c2 == "O" && c5 == "O" && c8 == "O";
//3,6,9
bool oWin6 = c3 == "O" && c6 == "O" && c9 == "O";
//1,5,9
bool oWin7 = c1 == "O" && c5 == "O" && c9 == "O";
//3,5,7
bool oWin8 = c7 == "O" && c5 == "O" && c3 == "O";
#endregion

//Initial table
Console.WriteLine($"{c1} | {c2} | {c3}\n" +
				  $"----------\n" +
				  $"{c4} | {c5} | {c6}\n" +
				  $"----------\n" +
				  $"{c7} | {c8} | {c9}\n");

while (!isGameOver)
{
	while (!isEndX)
	{
		Console.Write($"Player 1, choose cell (1-9): ");
		playerX = Console.ReadLine();

		switch (playerX)
		{
			case "1" when c1 != "O" && c1 != "X":
				c1 = "X";
				isEndX = true;
				break;
			case "2" when c2 != "O" && c2 != "X":
				c2 = "X";
				isEndX = true;
				break;
			case "3" when c3 != "O" && c3 != "X":
				c3 = "X";
				isEndX = true;
				break;
			case "4" when c4 != "O" && c4 != "X":
				c4 = "X";
				isEndX = true;
				break;
			case "5" when c5 != "O" && c5 != "X":
				c5 = "X";
				isEndX = true;
				break;
			case "6" when c6 != "O" && c6 != "X":
				c6 = "X";
				isEndX = true;
				break;
			case "7" when c7 != "O" && c7 != "X":
				c7 = "X";
				isEndX = true;
				break;
			case "8" when c8 != "O" && c8 != "X":
				c8 = "X";
				isEndX = true;
				break;
			case "9" when c9 != "O" && c9 != "X":
				c9 = "X";
				isEndX = true;
				break;
			default:
				Console.WriteLine("Invalid input or cell is filled. Please try again.");
				break;
		}
	}

	//Updating the values ​​of winning combinations for the first player
	#region
	//1,2,3
	xWin1 = c1 == "X" && c2 == "X" && c3 == "X";
	//4,5,6
	xWin2 = c4 == "X" && c5 == "X" && c6 == "X";
	//7,8,9
	xWin3 = c7 == "X" && c8 == "X" && c9 == "X";
	//1,4,7
	xWin4 = c1 == "X" && c4 == "X" && c7 == "X";
	//2,5,8
	xWin5 = c2 == "X" && c5 == "X" && c8 == "X";
	//3,6,9
	xWin6 = c3 == "X" && c6 == "X" && c9 == "X";
	//1,5,9
	xWin7 = c1 == "X" && c5 == "X" && c9 == "X";
	//3,5,7
	xWin8 = c7 == "X" && c5 == "X" && c3 == "X";
	#endregion

	//Print updated table
	Console.WriteLine($"{c1} | {c2} | {c3}\n" +
					  $"----------\n" +
					  $"{c4} | {c5} | {c6}\n" +
					  $"----------\n" +
					  $"{c7} | {c8} | {c9}\n");

	//Check if first player won
	if (xWin1 || xWin2 || xWin3 || xWin4 || xWin5 || xWin6 || xWin7 || xWin8)
	{
		Console.WriteLine("Player 1 win");
		isGameOver = true;
	}

	isEndX = false;

	while (!isEndO && !isGameOver)
	{
		Console.Write($"Player 2, choose cell (1-9): ");
		playerO = Console.ReadLine();

		switch (playerO)
		{
			case "1" when c1 != "X" && c1 != "O":
				c1 = "O";
				isEndO = true;
				break;
			case "2" when c2 != "X" && c2 != "O":
				c2 = "O";
				isEndO = true;
				break;
			case "3" when c3 != "X" && c3 != "O":
				c3 = "O";
				isEndO = true;
				break;
			case "4" when c4 != "X" && c4 != "O":
				c4 = "O";
				isEndO = true;
				break;
			case "5" when c5 != "X" && c5 != "O":
				c5 = "O";
				isEndO = true;
				break;
			case "6" when c6 != "X" && c6 != "O":
				c6 = "O";
				isEndO = true;
				break;
			case "7" when c7 != "X" && c7 != "O":
				c7 = "O";
				isEndO = true;
				break;
			case "8" when c8 != "X" && c8 != "O":
				c8 = "O";
				isEndO = true;
				break;
			case "9" when c9 != "X" && c9 != "O":
				c9 = "O";
				isEndO = true;
				break;
			default:
				Console.WriteLine("All cells are filled");
				isEndO = true;
				break;
		}
	}

	//Updating the values ​​of winning combinations for the second player
	#region
	//1,2,3
	oWin1 = c1 == "O" && c2 == "O" && c3 == "O";
	//4,5,6
	oWin2 = c4 == "O" && c5 == "O" && c6 == "O";
	//7,8,9
	oWin3 = c7 == "O" && c8 == "O" && c9 == "O";
	//1,4,7
	oWin4 = c1 == "O" && c4 == "O" && c7 == "O";
	//2,5,8
	oWin5 = c2 == "O" && c5 == "O" && c8 == "O";
	//3,6,9
	oWin6 = c3 == "O" && c6 == "O" && c9 == "O";
	//1,5,9
	oWin7 = c1 == "O" && c5 == "O" && c9 == "O";
	//3,5,7
	oWin8 = c7 == "O" && c5 == "O" && c3 == "O";
	#endregion

	//Print updated table
	Console.WriteLine($"{c1} | {c2} | {c3}\n" +
					  $"----------\n" +
					  $"{c4} | {c5} | {c6}\n" +
					  $"----------\n" +
					  $"{c7} | {c8} | {c9}\n");

	//Check if second player won
	if (oWin1 || oWin2 || oWin3 || oWin4 || oWin5 || oWin6 || oWin7 || oWin8)
	{
		Console.WriteLine("Player 2 win");
		isGameOver = true;
	}

	//Check if it's draw
	if (!xWin1 && !xWin2 && !xWin3 && !xWin4 && !xWin5 && !xWin6 && !xWin7 && !xWin8
		&& !oWin1 && !oWin2 && !oWin3 && !oWin4 && !oWin5 && !oWin6 && !oWin7 && !oWin8
		&& c1 != "1" && c2 != "2" && c3 != "3"
		&& c4 != "4" && c5 != "5" && c6 != "6"
		&& c7 != "7" && c8 != "8" && c9 != "9")
	{
		Console.WriteLine("It`s draw!");
		isGameOver = true;
	}

	isEndO = false;
}