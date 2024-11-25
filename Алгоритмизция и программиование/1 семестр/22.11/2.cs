Console.WriteLine("Введите строки");
string inp = Convert.ToString(Console.ReadLine());

while (inp.Length>0)
{
    string inp2 = inp.ToLower();
    inp2 = inp2.Replace("abc", "3").Replace("ab", "2").Replace("a", "1");
    char[] inparr = inp2.ToCharArray();
    Console.WriteLine(dl(inparr));
    
    inp = Convert.ToString(Console.ReadLine());
}


static int dl(char[] arr)
{
    int cnt = 0;
    int mx = 0;
    
    for (int i=0;i < arr.Length-1; i++)
    {      
        if ((arr[i] == arr[i+1] && arr[i] == '3')||(arr[i] == '3' && arr[i+1] == '2')||(arr[i] == '3' && arr[i+1] == '1'))
        {
            cnt = cnt + int.Parse(arr[i].ToString()) + int.Parse(arr[i+1].ToString());
            if (i > 0 && arr[i-1] == '3')
            {cnt -= int.Parse(arr[i].ToString());}
        }
        else
        {
            if (arr[i+1] == '3' || arr[i+1] == '2') {cnt += int.Parse(arr[i+1].ToString());}
            else {mx = Math.Max(mx, cnt); cnt = 0;}
        }
    }
    mx = Math.Max(mx, cnt);
    return mx;
}
