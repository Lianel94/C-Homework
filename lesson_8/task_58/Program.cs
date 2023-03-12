// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.Write("Type the number of rows for the 1st array: ");
int rowsOne = int.Parse(Console.ReadLine());
Console.Write("Type the number of columns for the 1st array: ");
int columnsOne = int.Parse(Console.ReadLine());

Console.Write("Type the number of rows for the 2nd array: ");
int rowsTwo = int.Parse(Console.ReadLine());
Console.Write("Type the number of columns for the 2nd array: ");
int columnsTwo = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rowsOne, columnsOne, 0, 10);
PrintArray(arrayOne);
Console.WriteLine();
int[,] arrayTwo = GetArray(rowsTwo, columnsTwo, 0, 10);
PrintArray(arrayTwo);
Console.WriteLine();

if(columnsOne != rowsTwo)
{
	Console.WriteLine("Error. Can't multiply");
	return;
}

PrintArray(GetMultiplyMtx(arrayOne, arrayTwo));

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] result = new int[rows, columns];
	for(int i = 0; i < rows; i++)
	{
		for(int j = 0; j < columns; j++)
		{
			result[i, j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return result;
}

void PrintArray(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}

int[,] GetMultiplyMtx(int[,] arrayOne, int[,] arrayTwo)
{
	int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
	for(int i = 0; i < arrayOne.GetLength(0); i++)
	{
		for(int j = 0; j < arrayTwo.GetLength(1); j++)
		{
			for(int y = 0; y < arrayOne.GetLength(1); y++)
			{
				result[i, j] += arrayOne[i, y] * arrayTwo[y, j];
			}
		}
	}
	return result;
}
