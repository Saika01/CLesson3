// 5-digit number is polindrome

bool IsPolindrome(int num)
{
        if (num/10000 == num%10)
        {
            num=(num/10000-num%10)/10;
            if (num/100 == num%10)
            {
                return true;
            }
        }
    return false;
}

void DoPolindrome(bool pol)
{
    if (pol) Console.WriteLine("Yes"); else Console.WriteLine("No");
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

if (number/100000 == 0 && number/10000 != 0) DoPolindrome(IsPolindrome(number)); 
else Console.WriteLine("Choose a differend number");


