Console.WriteLine("Input number from N");
int number = Convert.ToInt32(Console.ReadLine());

SquaresTable(number);

void SquaresTable(int num)
{
    int i = 1;
    while(i<=num)
    {
        Console.WriteLine($"Number: {i,3}, It squared: {i*i,4}");
        i++;
    }
}

