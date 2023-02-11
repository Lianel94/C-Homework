Console.Write("Type your number ");
int number = int.Parse(Console.ReadLine());
int ind = 1;

while (ind <= number){
    if (ind % 2 == 0){
        Console.Write(ind + " ");
    }
    ind++;
}
