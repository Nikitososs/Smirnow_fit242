int n = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int mxsum = -10000;
int sum = 0;
int flg = 0;
if (Math.Abs(a)%2==0) {sum = a;}

for (int i = 0; i < n-1; i++)
{
    int b = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(a)%2==0 && Math.Abs(b)%2==0){sum += b;}
    else {mxsum=Math.Max(mxsum, sum); sum = 0; flg = Math.Abs(flg-1);}
    a = b;
}
if (flg == 0) {mxsum=Math.Max(mxsum, sum);}
Console.WriteLine(mxsum);
