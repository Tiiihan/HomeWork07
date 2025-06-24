bool isEnd = false;
string playerX = "";
string playerO = "";

string cell1 = "1";
string cell2 = "2";
string cell3 = "3";
string cell4 = "4";
string cell5 = "5";
string cell6 = "6";
string cell7 = "7";
string cell8 = "8";
string cell9 = "9";

//Виграшні комбінації:
#region
//1,2,3
bool winCombinationX1 = cell1 == "X" && cell2 == "X" && cell3 == "X";
//4,5,6
bool winCombinationX2 = cell4 == "X" && cell5 == "X" && cell6 == "X";
//7,8,9
bool winCombinationX3 = cell7 == "X" && cell8 == "X" && cell9 == "X";
//1,4,7
bool winCombinationX4 = cell1 == "X" && cell4 == "X" && cell7 == "X";
//2,5,8
bool winCombinationX5 = cell2 == "X" && cell5 == "X" && cell8 == "X";
//3,6,9
bool winCombinationX6 = cell9 == "X" && cell6 == "X" && cell3 == "X";
//1,5,9
bool winCombinationX7 = cell1 == "X" && cell5 == "X" && cell9 == "X";
//3,5,7
bool winCombinationX8 = cell7 == "X" && cell5 == "X" && cell3 == "X";


//1,2,3
bool winCombinationO1 = cell1 == "O" && cell2 == "O" && cell3 == "O";
//4,5,6
bool winCombinationO2 = cell4 == "O" && cell5 == "O" && cell6 == "O";
//7,8,9
bool winCombinationO3 = cell7 == "O" && cell8 == "O" && cell9 == "O";
//1,4,7
bool winCombinationO4 = cell1 == "O" && cell4 == "O" && cell7 == "O";
//2,5,8
bool winCombinationO5 = cell2 == "O" && cell5 == "O" && cell8 == "O";
//3,6,9
bool winCombinationO6 = cell9 == "O" && cell6 == "O" && cell3 == "O";
//1,5,9
bool winCombinationO7 = cell1 == "O" && cell5 == "O" && cell9 == "O";
//3,5,7
bool winCombinationO8 = cell7 == "O" && cell5 == "O" && cell3 == "O";
#endregion

//Перше виведення
for (int i = 1; i <= 9; i++)
{
	switch (i)
	{
		case 1:
			Console.Write($"{cell1} | ");
			break;
		case 2:
			Console.Write($"{cell2} | ");
			break;
		case 3:
			Console.WriteLine($"{cell3}");
			break;
		case 4:
			Console.WriteLine($"----------");
			Console.Write($"{cell4} | ");
			break;
		case 5:
			Console.Write($"{cell5} | ");
			break;
		case 6:
			Console.WriteLine($"{cell6}");
			break;
		case 7:
			Console.WriteLine($"----------");
			Console.Write($"{cell7} | ");
			break;
		case 8:
			Console.Write($"{cell8} | ");
			break;
		case 9:
			Console.WriteLine($"{cell9}");
			break;
	}
}

while (!isEnd)
{
	Console.Write($"Player 1, enter number you want to choose: ");
	playerX = Console.ReadLine();

	switch (playerX)
	{
		case "1" when cell1 != "O":
			cell1 = "X";
			break;
		case "2" when cell2 != "O":
			cell2 = "X";
			break;
		case "3" when cell3 != "O":
			cell3 = "X";
			break;
		case "4" when cell4 != "O":
			cell4 = "X";
			break;
		case "5" when cell5 != "O":
			cell5 = "X";
			break;
		case "6" when cell6 != "O":
			cell6 = "X";
			break;
		case "7" when cell7 != "O":
			cell7 = "X";
			break;
		case "8" when cell8 != "O":
			cell8 = "X";
			break;
		case "9" when cell9 != "O":
			cell9 = "X";
			break;
	}
	#region
	//1,2,3
	winCombinationX1 = cell1 == "X" && cell2 == "X" && cell3 == "X";
	//4,5,6
	winCombinationX2 = cell4 == "X" && cell5 == "X" && cell6 == "X";
	//7,8,9
	winCombinationX3 = cell7 == "X" && cell8 == "X" && cell9 == "X";
	//1,4,7
	winCombinationX4 = cell1 == "X" && cell4 == "X" && cell7 == "X";
	//2,5,8
	winCombinationX5 = cell2 == "X" && cell5 == "X" && cell8 == "X";
	//3,6,9
	winCombinationX6 = cell9 == "X" && cell6 == "X" && cell3 == "X";
	//1,5,9
	winCombinationX7 = cell1 == "X" && cell5 == "X" && cell9 == "X";
	//3,5,7
	winCombinationX8 = cell7 == "X" && cell5 == "X" && cell3 == "X";

	Console.WriteLine($"{cell1} | {cell2} | {cell3}\n" +
					  $"----------\n" +
					  $"{cell4} | {cell5} | {cell6}\n" +
					  $"----------\n" +
					  $"{cell7} | {cell8} | {cell9}\n");
	#endregion

	if (winCombinationX1 || winCombinationX2 || winCombinationX3 || winCombinationX4 || winCombinationX5 || winCombinationX6 || winCombinationX7 || winCombinationX8)
	{
		Console.WriteLine("Player 1 win");
		isEnd = true;
	}

	Console.Write($"Player 2, enter number you want to choose: ");
	playerO = Console.ReadLine();

	switch (playerO)
	{
		case "1" when cell1 != "X":
			cell1 = "O";
			break;
		case "2" when cell2 != "X":
			cell2 = "O";
			break;
		case "3" when cell3 != "X":
			cell3 = "O";
			break;
		case "4" when cell4 != "X":
			cell4 = "O";
			break;
		case "5" when cell5 != "X":
			cell5 = "O";
			break;
		case "6" when cell6 != "X":
			cell6 = "O";
			break;
		case "7" when cell7 != "X":
			cell7 = "O";
			break;
		case "8" when cell8 != "X":
			cell8 = "O";
			break;
		case "9" when cell9 != "X":
			cell9 = "O";
			break;
	}

	#region
	//1,2,3
	winCombinationO1 = cell1 == "O" && cell2 == "O" && cell3 == "O";
	//4,5,6
	winCombinationO2 = cell4 == "O" && cell5 == "O" && cell6 == "O";
	//7,8,9
	winCombinationO3 = cell7 == "O" && cell8 == "O" && cell9 == "O";
	//1,4,7
	winCombinationO4 = cell1 == "O" && cell4 == "O" && cell7 == "O";
	//2,5,8
	winCombinationO5 = cell2 == "O" && cell5 == "O" && cell8 == "O";
	//3,6,9
	winCombinationO6 = cell9 == "O" && cell6 == "O" && cell3 == "O";
	//1,5,9
	winCombinationO7 = cell1 == "O" && cell5 == "O" && cell9 == "O";
	//3,5,7
	winCombinationO8 = cell7 == "O" && cell5 == "O" && cell3 == "O";

	Console.WriteLine($"{cell1} | {cell2} | {cell3}\n" +
					  $"----------\n" +
					  $"{cell4} | {cell5} | {cell6}\n" +
					  $"----------\n" +
					  $"{cell7} | {cell8} | {cell9}\n");
	#endregion

	if (winCombinationO1 || winCombinationO2 || winCombinationO3 || winCombinationO4 || winCombinationO5 || winCombinationO6 || winCombinationO7 || winCombinationO8)
	{
		Console.WriteLine("Player 2 win");
		isEnd = true;
	}
}

//for (int i = 1; i <= 9; i++)
//{
//	switch (i)
//	{
//		case 1:
//			Console.Write($"{cell1} | ");
//			break;
//		case 2:
//			Console.Write($"{cell2} | ");
//			break;
//		case 3:
//			Console.WriteLine($"{cell3}");
//			break;
//		case 4:
//			Console.WriteLine($"----------");
//			Console.Write($"{cell4} | ");
//			break;
//		case 5:
//			Console.Write($"{cell5} | ");
//			break;
//		case 6:
//			Console.WriteLine($"{cell6}");
//			break;
//		case 7:
//			Console.WriteLine($"----------");
//			Console.Write($"{cell7} | ");
//			break;
//		case 8:
//			Console.Write($"{cell8} | ");
//			break;
//		case 9:
//			Console.WriteLine($"{cell9}");
//			break;
//	}
//}