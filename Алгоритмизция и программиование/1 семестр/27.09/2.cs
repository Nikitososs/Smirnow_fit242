int n = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int max2 = b;
if (b>a)
{max = b; max2 = a;}
for(int i = 0; i<n-2; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > max)
    {
        max2 = max;
        max = a;
    }
    else
    {
        if (a > max2)
        {
            max2 = a;
        }
    }
    
}
Console.WriteLine(max2);
