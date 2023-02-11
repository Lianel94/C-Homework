Console.Write("Type your number ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0){
    Console.Write("The number " + number + " is even");
}
else Console.Write("The number " + number + " is odd");
