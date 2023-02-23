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

