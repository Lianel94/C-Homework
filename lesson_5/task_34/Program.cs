// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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

int GetEvenElements(int[] array)
{
	int numberEvenElements = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] % 2 == 0) numberEvenElements += 1;
	}
	return numberEvenElements;
}

int[] array = GetArray(3, 100, 999);
Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine($"The number of even elemetns in the {String.Join(", ", array)} is {GetEvenElements(array)}");