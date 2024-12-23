///Дан массив размерностью m на n, определить номера одинаковых строк
Console.WriteLine("Введите m размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr  = get_arr(m, n);

Console.WriteLine("Входной массив:");
display_arr(arr, m, n);

int[][] linearr = line_arr(arr,m,n);

var res = pairs(linearr, m);

Console.WriteLine("Пары номеров одинаковых строк:");
foreach (int[] i in res)
{
    try {Console.WriteLine($"{i[0]} {i[1]}");}
    catch (Exception e) {continue;}
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

static int[][] line_arr(int[] arr, int m, int n)
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

static int[][] pairs(int[][] arr, int m)
{
    int[][] exit  = new int[m*m][];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (compare(arr[i], arr[j]) == true)
            {
                if(i!=j)
                {
                    int[] pair = {i, j};
                    exit[i] = pair;
                }
            };
        }   
    }
    return exit;
}

static bool compare(int[] a, int[] b)
{
    bool flag = true;
    foreach (int i in a)
    {
        if ((Array.IndexOf(b, i) == -1) || (cntt(a,i)!=cntt(b,i)))
        {
            flag = false; break;
        }
    }
    return flag;
}

static int cntt(int[] a, int s)
{
    int cnt = 0;
    foreach (int i in a)
    {
        if (i==s)
        {
            cnt+=1;
        }
    }
    return cnt;
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
