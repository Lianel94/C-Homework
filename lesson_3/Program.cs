// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Type a 5-digit number: ");
string userNumber = Console.ReadLine();

if(userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
{
	Console.WriteLine($"The number {userNumber} is a palindrome");
} else Console.WriteLine($"The number {userNumber} is NOT a palindrome");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Type X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Type Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Type Z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Type X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Type Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Type Z2: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"The distance between two points is {distance:f2}");

