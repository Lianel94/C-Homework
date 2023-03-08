// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Type the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Type the number of columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(row, columns);
PrintArray(array);
FindAverage(array, row);

double[,] GetArray(int m, int n)
{
	double[,] result = new double[m, n];
	for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			result[i, j] = Math.Round(new Random().Next(11)*0.1*10, 1);;
		}
	}
	return result;
}

void PrintArray(double[,] inArray)
{
	for(int i = 0; i < inArray.GetLength(0); i++)
	{
		for(int j = 0; j < inArray.GetLength(1); j++)
		{
			Console.Write($"{inArray[i, j]} ");
		}
		Console.WriteLine();
	}
}

void FindAverage(double[,] array, int row)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = (average + array[i, j]);
    }
    average = average / row;
    Console.Write($"average = {average:f1} ");
}
}
