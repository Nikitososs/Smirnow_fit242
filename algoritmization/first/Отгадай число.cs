const string path = "C:\\Users\\nsmir\\algoritmization\\sample1\\chisla";
System.IO.FileInfo[] a = new System.IO.DirectoryInfo(path).GetFiles();
for (int i = 0; i < a.Length / 2; i++)
{
    Console.WriteLine("Обработка файла " + a[i]);
    string[] file = System.IO.File.ReadAllLines($"{a[i]}");
    int n = Convert.ToInt32(file[0]);
    int res = Convert.ToInt32(file[n+1]);
    int kf = 1;
    int ch = 0;
    for (int j = 1; j <= n; j++)
    {
        string[] st = file[j].Split(" ");
        string operation = st[0];
        string operand = st[1];
        if (operation == "+") 
        {
            if (operand == "x"){kf+=1;}
            else {ch+=Convert.ToInt32(operand);}
        }
        else if (operation == "-") 
        {
            if (operand == "x"){kf-=1;}
            else {ch-=Convert.ToInt32(operand);}
        }
        else if (operation == "*") 
        {
            kf*=Convert.ToInt32(operand);
            ch*=Convert.ToInt32(operand);
        }
    }
    Console.WriteLine($"Загаданное число: {(res-ch)/kf}");
    Console.WriteLine($"Число из ответа (для сверки): {System.IO.File.ReadAllLines($"{a[i+12]}")[0]}");
}
