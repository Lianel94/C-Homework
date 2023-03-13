// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Type the first number: ");
int m = int.Parse(Console.ReadLine());
Console.Write("type the second number: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(m, n));

int GetSum(int start, int end)
{
	if(start == end) return end;
	return(start + GetSum(start + 1, end));
}
