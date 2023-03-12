// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int RowColumn = 4;
int[,] array = GetArray(RowColumn);
PrintArray(array);

int[,] GetArray(int size)
{
	int[,] result = new int[size, size];
	int startOfRow = 0;
	int startOfColumn = 0;
	int endOfRow = size - 1;
	int endOfColumn = size - 1;
	int idx = 0;
	int i = 0;
	int j = 0;
	bool left = true;
	bool top = true;
	
	while(idx < size * size)
	{
		idx++;
		result[i,j] = idx;
		if(top && left)
		{
			if(j == endOfColumn)
			{
				startOfRow++;
				top = true;
				left = false;
				i++;
				continue;
			} else 
			{
				j++;
				continue;
			}
		}
		if(top && !left)
		{
			if(i == endOfRow)
			{
				endOfColumn--;
				top = false;
				left = false;
				j--;
				continue;
			} else
			{
				i++;
				continue;
			}
		}
		if(!top && !left)
		{
			if(j == startOfColumn)
			{
				endOfRow--;
				top = false;
				left = true;
				i--;
				continue;
			} else
			{
				j--;
				continue;
			}
		}
		if(!top && left)
		{
			if(i == startOfRow)
			{
				startOfColumn++;
				top = true;
				left = true;
				j++;
				continue;
			} else
			{
				i--;
				continue;
			}
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