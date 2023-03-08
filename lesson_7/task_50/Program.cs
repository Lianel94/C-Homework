// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();

Console.WriteLine("Type the number of a row");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the number of a column");
int userColumn = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [5,5];

GetArray(array);
PrintArray(array);
FindElement(userRow, userColumn, array);

void GetArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		{        
			for (int j = 0; j < array.GetLength(1); j++)
			{
				array [i,j] = new Random().Next(1, 11);
			}   
		}
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i,j] + " ");
		}   
		Console.WriteLine();
	}
}


void FindElement(int userRow, int userColumn, int[,] array)
{
	if (userRow > array.GetLength(0) || userColumn > array.GetLength(1))
{
	Console.WriteLine("No element");
}
else
{
	Console.WriteLine($"The element of row{userRow} and column{userColumn} is {array[userRow-1,userColumn-1]}");
}
}