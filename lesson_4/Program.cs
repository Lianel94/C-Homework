// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Type the number: ");
int userNum = int.Parse(Console.ReadLine());

Console.Write("Type the power: ");
int userPower = int.Parse(Console.ReadLine());

bool ValidatePower (int userPower)
{
	if(userPower < 0)
	{
		Console.WriteLine("Error. The power must be more than 0");
		return false;
	} return true;
}

int GetResult(int userNum, int userPower)
{
	int result = 1;
	for (int i = 0; i < userPower; i++)
	{
		result *= userNum;
	}
	return result;
}

if(ValidatePower(userPower))
{
	Console.WriteLine($"The number {userNum} to the power of {userPower} is {GetResult(userNum, userPower)} ");
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Type your number: ");
int num = int.Parse(Console.ReadLine());

int GetSum(int num)
{
	int res = 0;
	while(num > 0)
	{
		res += num % 10;
		num = num / 10;
	}
	return res;
}

Console.WriteLine($"The sum of the digits of {num} is {GetSum(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int size)
{
	int[] result = new int[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(10, 51);
	}
	return result;
}

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");