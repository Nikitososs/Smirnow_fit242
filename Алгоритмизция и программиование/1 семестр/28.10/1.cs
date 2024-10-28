int[][] arr = new int[3][];

for (int i=0; i<3; i++)
{
    Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr1 = new int[n];
    for (int j = 0; j<n;j++)
    {
        arr1[j] = Convert.ToInt32(Console.ReadLine());
    }
    arr[i] = arr1;
}

static int nechet(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (Math.Abs(arr[i])%2!=0){cnt += 1;}
    }
    return cnt;
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Колтчество нечётных вкааждом масиве:");
    Console.WriteLine(nechet(arr[i]));
}
