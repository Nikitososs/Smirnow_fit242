Console.WriteLine("Введите строки");
string inp = Convert.ToString(Console.ReadLine());

while (inp.Length>0)
{
    string inp2 = inp.ToLower();
    inp2 = inp2.Replace("abc", "***").Replace("ab", "**").Replace("a", "*");
    char[] inparr = inp2.ToCharArray();
    Console.WriteLine(dl(inparr));
    
    inp = Convert.ToString(Console.ReadLine());
}


static int dl(char[] arr)
{
    int cnt = 1;
    int mx = 0;
    
    for (int i=0;i < arr.Length-1; i++)
    {      
        if (arr[i] == arr[i+1] && arr[i] == '*')
        {cnt += 1;}
        else
        {mx = Math.Max(mx, cnt); cnt = 1;}
    }
    mx = Math.Max(mx, cnt);
    return mx;
}

