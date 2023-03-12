//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Type the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Type the number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
MaxToMin(array);
PrintArray(array);

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

void MaxToMin(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			for(int aj = j + 1; aj < array.GetLength(1); aj++)
			{
				if(array[i, aj] > array [i, j])
				{
					int changedArr = array[i, j];
					array[i, j] = array[i, aj];
					array[i, aj] = changedArr;
				}
			}
		}
	}
}

