int n = Convert.ToInt32(Console.ReadLine());

while (n > 0)
{
    int exit = 0;
    while (n>0)
    {
        if (n%10%2!=0)
        {exit += n%10;
        exit *= 10;
        n /= 10;}
        else n/=10;
    }
    if (exit!=0){Console.WriteLine(exit/10);}
    else Console.WriteLine("Нет нечётных цифр");
    n = Convert.ToInt32(Console.ReadLine());
}
