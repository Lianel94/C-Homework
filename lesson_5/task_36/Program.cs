// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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

int GetSum(int[] array)
{
	int result = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(i % 2 != 0)
		{
			result += array[i];
		}
	}
	return result;
}

Console.Write("Type the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size, -99, 99);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"The sum of the elements taking odd positions in the array [{String.Join(", ", array)}] is {GetSum(array)}");