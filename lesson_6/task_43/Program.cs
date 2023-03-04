// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Type k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Type b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Type k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Type b2: ");
double b2 = double.Parse(Console.ReadLine());


double[] FindIntersection(double k1, double k2, double b1, double b2)
{
	double[] array = new double[2];
	if(k1 == k2 && b1 == b2)
	{
		Console.WriteLine("Прямые совпадают");
	} else if (k1 == k2) 
	{
		Console.WriteLine("Прямые параллельны");
	} else
	{
		array[0] = (b2-b1)/(k1-k2);
		array[1] = (k1*(b2-b1))/(k1-k2)+b1;
	}
	return array;
}

Console.WriteLine($"{String.Join("; ", FindIntersection(k1, k2, b1, b2))}");

