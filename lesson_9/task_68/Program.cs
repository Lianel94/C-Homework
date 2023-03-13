// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Type the first positive number: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Type the second positive number: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(AkkermanSum(m, n));

int AkkermanSum(int m, int n)
{
	if(m == 0) return n+1;
	if(n == 0) return AkkermanSum(m-1, 1);
	return AkkermanSum(m-1, AkkermanSum(m, n-1));
}
