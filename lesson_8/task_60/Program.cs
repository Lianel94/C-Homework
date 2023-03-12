// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Type the 1st number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Type the 2nd number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Type the 3rd number: ");
int num3 = int.Parse(Console.ReadLine());

int[,,] array = GetArray(new int[] {num1, num2, num3}, 10, 100);
PrintArray(array);

int[,,] GetArray(int[] size, int minValue, int maxValue)
{
	int[,,] result = new int[size[0], size[1], size[2]];
	for(int i = 0; i < result.GetLength(0); i++)
	{
		for(int j = 0; j < result.GetLength(1); j++)
		{
			int y = 0;
			while(y < result.GetLength(2))
			{
				int item = new Random().Next(minValue, maxValue);
				if(SameItem(result, item)) continue;
				result[i,j,y] = item;
				y++;
			}
		}
	}
	return result;
}

void PrintArray(int[,,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			for(int y = 0; y < array.GetLength(2); y++)
			{
				Console.Write($"{array[i, j, y]} ({i}, {j}, {y}) ");
			}
		}
		Console.WriteLine();
	}
}

bool SameItem(int[,,] array, int item)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			for(int y = 0; y < array.GetLength(2); y++)
			{
				if(array[i,j,y] == item) return true;
			}
		}
	}
	return false;
}