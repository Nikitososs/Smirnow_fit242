/// дан массив m на n
/// 2.сформировать одномерный массив из максимальных элементов строк

Console.WriteLine("Введите m размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr  = get_arr(m, n);

Console.WriteLine("Входной массив:");
display_arr(arr, m, n);

int[][] linearr = line_or(arr,m,n);
int[] maxed = mx(linearr);

Console.WriteLine("Выходной массив:");
foreach (int i in maxed){Console.WriteLine(i);}




static int[] mx(int[][] arr)
{
    int[] mxarr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        mxarr[i] = arr[i].Max();
    }
    return mxarr;
} 


static int[] get_arr(int m, int n)
{
    int[] arr  = new int[n*m];
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < n*m; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

static int[][] line_or(int[] arr, int m, int n)
{
    int cnt = 0;
    int[][] linearr = new int[m][];
    for (int i = 0; i < m; i++)
    {
        int[] line = new int[n];
        for (int j = 0; j < n; j++) 
        {
            line[j] = arr[i*n+j];
            if (cnt==n){cnt=0; break;}

        }
        linearr[i] = line;
    }
    return linearr;
}

static void display_arr(int[] arr, int m, int n)
{
    int cnt = 0;
    string a = "";
    for (int i = 0; i < n*m; i++)
    {
        a += $"{arr[i]} ";
        cnt +=1;
        if (cnt==n){a += "\n";cnt=0;}
        }
    Console.WriteLine(a);
}

