Console.WriteLine("Введите строки");
string inp = Convert.ToString(Console.ReadLine());
int cnt = 0;

while (inp != "")
{
    string inp2 = inp.ToLower();
    char[] inparr = inp2.ToCharArray();
    cnt += isin(inparr);
    
    inp = Convert.ToString(Console.ReadLine());
}
Console.WriteLine(cnt);

static int isin(char[] arr)
{
    if (arr.Length < 3){return 0;}
    else
    {
        int c = 0;
        for (;c < arr.Length-3; c++);
        {
            if (arr[c] == 'a' && arr[c+2] == 'b')
            {return 1;}
            else 
            {return 0;
            }
            
        }
    }
}
