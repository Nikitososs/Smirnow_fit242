const string path = "C://Users//nsmir//algoritmization//sample1//moloko";
System.IO.FileInfo[] a = new System.IO.DirectoryInfo(path).GetFiles();
for (int i = 0; i < a.Length / 2; i++)
{
    Console.WriteLine($"Обработка файла {a[i]}");
    string[] file = System.IO.File.ReadAllLines($"{a[i]}");
    double m = 1000;
    int n = 0;
    for (int j = 1; j <= int.Parse(file[0]); j++)
    {
        string[] line = file[j].Split(' ');
        float z1 = float.Parse(line[0]); 
        float x1 = float.Parse(line[1]);
        float y1 = float.Parse(line[2]);
        float z2 = float.Parse(line[3]);
        float x2 = float.Parse(line[4]);
        float y2 = float.Parse(line[5]);
        float c1 = float.Parse(line[6].Replace('.', ',')); 
        float c2 = float.Parse(line[7].Replace('.', ','));

        float res = formula(c1,c2,x1,y1,z1,x2,y2,z2);
        if (m > res)
        {
            m = Math.Round(res, 2);
            n = j;
        }
    }
            Console.WriteLine($"Ответ: {n} {m.ToString().Replace(',', '.')}");
            Console.WriteLine($"Для Сверки: {System.IO.File.ReadAllLines($"{a[i + 10]}")[0]}\n");
}

static float formula(float c1, float c2, float x1, float y1, float z1, float x2, float y2, float z2)
{
    return 1000 * ((c2 * (x1 * y1 + z1 * y1 + z1 * x1) - c1 * (x2 * y2 + z2 * y2 + z2 * x2)) 
    / ((z2 * x2 * y2) * (x1 * y1 + z1 * y1 + z1 * x1) - (x2 * y2 + z2 * y2 + z2 * x2) * (z1 * x1 * y1)));
}
