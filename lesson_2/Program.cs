// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число: ");
int userNum = int.Parse(Console.ReadLine());

if(userNum < 100 || userNum >= 1000) 
{
	Console.Write("Ошибка. Введите трехзначное число.");
	return;
}
else 
{
	Console.WriteLine($"Вторая цифра числа {userNum} - {userNum / 10 % 10}");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Type a 3-or-more-digit number: ");
int userNumber = int.Parse(Console.ReadLine());

if(userNumber < 100)
{
	Console.WriteLine("There's no third digit");
	return;
} 
else 
{
	while(userNumber > 999)
	{
		userNumber /= 10;
	}
	Console.WriteLine($"The third digit of the number is {userNumber % 10}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool isCorrectNumber (int dayOfWeek)
{
	if(dayOfWeek > 0 && dayOfWeek <= 7) return true;
	Console.WriteLine("It's not the day of the week");
	return false;
}

bool isWeekend (int dayOfWeek)
{
	if(dayOfWeek > 5) return true;
	return false;
}

Console.Write("Type the number from 1 to 7, indicating the days of the week: ");
int dayOfWeek = int.Parse(Console.ReadLine());

if(isCorrectNumber(dayOfWeek))
{
	if(isWeekend(dayOfWeek))
	{
		Console.WriteLine("It's a weekend");
	}
	else
	{
		Console.WriteLine("It's a weekday");
	}
}