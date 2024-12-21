///    18.11
///    на вход подается строка, состоящая из слов, между которыми 1 и более пробелов.
///    1 задание: отформатировать строку таким образом, чтобы между словами оставалось ровно по одному пробелу
///    2 задание: выдать все слова палиндромы
///    3 задание: посчитать количество слов, в которых кол-во гласных букв меньше чем количество согласных

int v = -1;
int flag = 0;
string str = null;
while (v != 4)
{
    v = Menu();
    if (v==0)
    {
        Console.WriteLine("Введите строку:");
        str = Console.ReadLine();
        flag = 1;
    }
    
    if (v==1){if(flag == 1){Console.WriteLine(space(str));} else {Console.WriteLine("Строка не задана");}}
    else if (v==2){if(flag == 1){print_palyndroms(str);} else {Console.WriteLine("Строка не задана");}}
    else if (v==3){if(flag == 1){Console.WriteLine($"Количество: {count(str)}");} else {Console.WriteLine("Строка не задана");}}
    
}

static int Menu()
{
    Console.WriteLine("Меню:\n0) Ввести строку\n1) Убрать лишние пробелы\n2) Найти палиндромы\n3) Количество слов, в которых количество гласных меньше чем согласных\n4) Выход");
    return Convert.ToInt32(Console.ReadLine());
}

static string space(string str)
{
    while (str.IndexOf("  ")!=-1)
    {
        str = str.Replace("  ", " ");
    }
    return str;
}

static void print_palyndroms(string str)
{
    str = space(str);
    str = str.ToLower();
    string[] arr = str.Split(" ");
    for (int i = 0; i < arr.Length; i++){if (is_paly(arr[i]) == true){Console.WriteLine(arr[i]);}}

    static bool is_paly(string str)
    {
        int j =  str.Length-1;
        for (int i = 0; i < j; i++)
        {
            if (str[i]!=str[j]){return false;}
            j--;
        }
        return true;
    }

}

static int count(string str)
{
    int cnt = 0;

    string g = "аеёиоуыэюя";
    string s = "бвгджзйклмнпрсефчцчшщ";
    
    str = space(str);
    str = str.ToLower();
    string[] arr = str.Split(" ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (count_g(arr[i]) < count_s(arr[i])){cnt += 1;}
    }
    return cnt;

    int count_g(string str)
    {
        int c = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (g.Contains(str[i])){c += 1;}
        }
        return c;
    }
    int count_s(string str)
    {
        int c = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (s.Contains(str[i])){c += 1;}
        }
        return c;
    }

}
