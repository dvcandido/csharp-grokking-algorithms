int val = 3;

Console.WriteLine($"The factorial of {val} is {fat(val)}");

int fat(int val)
{
    if (val == 1)
        return 1;
    else
        return val * fat(val-1);
}