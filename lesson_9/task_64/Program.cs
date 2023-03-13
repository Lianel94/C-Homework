// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Type N: ");
int n = int.Parse(Console.ReadLine());
int end = 1;

Console.WriteLine(PrintNumbers(n, end));

string PrintNumbers(int n, int end)
{
	if(n == 1)
	{
		Console.WriteLine(1);
		return "1";
	}
	return (n + " " + PrintNumbers(n-1, end));
}
