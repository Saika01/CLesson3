Console.WriteLine("Input number from N");
int number = Convert.ToInt32(Console.ReadLine());

SquaresTable(number);

void SquaresTable(int num)
{
    int i = 1;
    while(i<=num)
    {
        Console.WriteLine($"{i,3} | {i*i*i,5}");
        i++;
    }
}
