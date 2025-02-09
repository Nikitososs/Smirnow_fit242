///Дан массив размерностью m на n, путём перестановки строк и столбцов поместить максимальный элемент в правый верхний угол.
Console.WriteLine("Введите m размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr  = get_arr(m, n);

Console.WriteLine("Входной массив:");
display_arr(arr, m, n);

int mcord = 0;
int ncord = 0;
int mx = arr.Max();

for (int i = 0; i < n*m; i++)
{
    if (arr[i]==mx)
    {
        ncord = (i+1)/n;
        mcord = (i+1)/m;
    }
}
if (mcord == 0){mcord = 1;}
if (ncord == 0){ncord = 1;}


int[][] linearr = line_or(arr,m,n);

var first = linearr[0];
linearr[0] = linearr[mcord-1];
linearr[mcord-1] = first;

int[][] columnarr = line_to_column(linearr,m,n);

var last = columnarr[n-1];
columnarr[n-1] = columnarr[ncord-1];
columnarr[ncord-1] = last;

Console.WriteLine("Выходной массив:");
display_arr(column_to_normal(columnarr, m, n), m,n);












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

static int[][] line_to_column(int[][] arr, int m, int n)
{
    int inc = 0;
    int[][] columnarr = new int[n][];
    for (int i = 0; i < n; i++, inc ++)
    {
        int[] column = new int[m];
        for (int j = 0; j < m; j++) 
        { 
            column[j] = arr[j][inc];
        }
        
        columnarr[i] = column;
    }
    return columnarr;
}

static int[] column_to_normal(int[][] arr, int m, int n)
{
    int cnt = 0;
    int[] norm = new int[n*m];
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        {
            norm[cnt] = arr[j][i];
            cnt+=1;
        }
    }
    return norm;
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
