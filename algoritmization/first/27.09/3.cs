int n = Convert.ToInt32(Console.ReadLine());
int c = 0;
for(int i = 0; i<n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(a) % 10 == 4)
    {
        c += 1;
    }
}
Console.WriteLine(c);
