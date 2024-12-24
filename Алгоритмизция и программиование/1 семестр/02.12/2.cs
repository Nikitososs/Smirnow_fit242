using System;
namespace Wtf
{
    class Programm
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите строку:");
                Xz a = new Xz() {data = Console.ReadLine()};
                Console.WriteLine(a.Chet());
            }
        }
    }
    class Xz 
    {
        private string _data;
        public string data {get {return _data;} set {_data = value;}}

        public Xz(){}

        public bool Chet()
        {
            char[] data_char = _data.ToCharArray();
            for (int i = 0; i < data_char.Length-1; i++)
            {
                if (!char.IsDigit(data_char[i+1]))
                {
                    if (char.IsDigit(data_char[i]))
                    {if (Convert.ToInt32(data_char[i])%2==0){return true;}}
                }
            }
            if (char.IsDigit(data_char[data_char.Length-1])){return true;}

            return false;
        }
    }
}
