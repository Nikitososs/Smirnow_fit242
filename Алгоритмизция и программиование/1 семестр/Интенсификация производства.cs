System.IO.FileInfo[] a = new System.IO.DirectoryInfo("C://Users//nsmir//algoritmization//sample1//proizv").GetFiles();
for (int i = 0; i < a.Length/2; i++) 
{
    Console.WriteLine($"Файл {a[i]}");
    string[] file = System.IO.File.ReadAllLines($"{a[i]}");
    string[] stline = file[0].Split(".");
    int day = int.Parse(stline[0]);
    int month = int.Parse(stline[1]);
    int year = int.Parse(stline[2]);

    string[] edline = file[1].Split(".");
    int edday = int.Parse(edline[0]);
    int edmonth = int.Parse(edline[1]);
    int edyear = int.Parse(edline[2]);

    int stproduct = int.Parse(file[2]);

    var start_date = new DateTime(year, month, day);
    var end_date = new DateTime(edyear, edmonth, edday);

    var dist = (end_date-start_date).TotalDays+1;


    Console.WriteLine($"Ответ: {((stproduct+dist-1)+stproduct)*dist/2}");
    Console.WriteLine($"Для сверки: {System.IO.File.ReadAllLines($"{a[i + 8]}")[0]}");
    
}
