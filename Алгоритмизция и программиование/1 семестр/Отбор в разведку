System.IO.FileInfo[] a = new System.IO.DirectoryInfo("C://Users//nsmir//algoritmization//sample1//razv").GetFiles();
for (int i = 0; i < a.Length/2; i++) 
{
    Console.WriteLine($"Файл {a[i]}");
    string[] file = System.IO.File.ReadAllLines($"{a[i]}");
    int N = int.Parse(file[0]);
    Console.WriteLine($"Ответ: {cnt(N)}");
    Console.WriteLine($"Для сверки: {System.IO.File.ReadAllLines($"{a[i + 10]}")[0]}");
}
static int cnt(int N)
{
    if (N < 3) {return 0;}
    else {return cntt(N);}
}
static int cntt(int N)
{
    if (N == 3) {return 1;}
    else if (N < 3) {return 0;}
    else {return cntt(N / 2) + cntt((N + 1) / 2);}
    
}
