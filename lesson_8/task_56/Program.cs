//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Type the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Type the number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"The row with the min sum is {GetRowNum(array)}");


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] result = new int[rows, columns];
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			result[i, j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return result;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}

int GetRowNum(int[,] array)
{
	int minRow = 0;
	int minSum = 0;
	for(int i = 0; i < array.GetLength(1); i++)
	{
		minSum += array[0, i];
	}

	for(int i = 1; i < array.GetLength(0); i++)
	{
		int rowSum = 0;
		for(int j = 0; j < array.GetLength(1); j++)
		{
			rowSum += array[i, j];
		}
		if(minSum > rowSum)
		{
			minSum = rowSum;
			minRow = i;
		}
	}
	return minRow;
}
