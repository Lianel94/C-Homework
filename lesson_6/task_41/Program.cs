// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int MakeNumber(string userText)
{
	Console.Write(userText);
	string text = Console.ReadLine();
	int number = Convert.ToInt32(text);
	return number;
}

int[] GetArray(int size)
{
	int[] array = new int[size];
	for(int i = 0; i < size; i++)
	{
		array[i] = MakeNumber($"Number {i + 1} = ");
	}
	Console.WriteLine($"{String.Join(", ", array)}");
	return array;
}

int PosNum(int[] array)
{
	int count = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] > 0)
		{
			count++;
		}
	}
	return count;
}

int size = MakeNumber("Type the number of elements: ");
int[] array = GetArray(size);
Console.WriteLine($"The number of posititves are {PosNum(array)}");

