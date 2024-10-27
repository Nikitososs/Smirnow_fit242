int n = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int localmax = 0;
for(int i = 0; i<n-1; i++)
{
    int b = Convert.ToInt32(Console.ReadLine());
    if (b>a){localmax+=1;}
    a=b;
}
Console.WriteLine(localmax);
