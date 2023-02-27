// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
	int[] result = new int[size];
	for(int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int GetDifference(int[] array)
{
	int min = 0;
	int max = 0;
	int result = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] > array[max])
		{
			max = i;
		} else if(array[i] < array[min])
		{
			min = i;
		}
	}
	return (result = array[max] - array[min]);
}

Console.Write("Type the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size, 1, 99);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"the fifference between max and min in the array [{String.Join(", ", array)}] is {GetDifference(array)}");
