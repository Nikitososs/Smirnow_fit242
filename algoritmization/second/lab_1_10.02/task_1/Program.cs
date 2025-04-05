using System;
namespace Wtf
{
    class Programm
    {
        public static void Main()
        {
            int flag = 0;
            int x = 0;
            Abonent[] db = null;

            while (x!=5)
            {
                x = menu(flag);
                if (x == 1)
                {
                    flag = 1;
                    db = database();
                }
                else if (x == 2)
                {
                    Console.WriteLine("Введите город подключения");
                    string city = Console.ReadLine();
                    Console.WriteLine("Выборка по городу подключения:");
                    for (int i = 0; i < db.Length; i++)
                    {
                        if (db[i].city == city)
                        {
                            db[i].Print();
                        }
                    }
                }
                else if (x == 3)
                {
                    Console.WriteLine("Введите номер подключения");
                    string nomer = Console.ReadLine();
                    Console.WriteLine("Выборка по номеру подключения:");
                    for (int i = 0; i < db.Length; i++)
                    {
                        for (int k = 1; k < db[i].nomera.Length; k++)
                        {
                            if ((db[i].nomera)[k].number==nomer){db[i].Print();}
                        }
                    }
                }
                else if (x == 4)
                {
                    Console.WriteLine("Введите оператора подключения");
                    string oper = Console.ReadLine();
                    Console.WriteLine("Выборка по оператору подключения:");
                    for (int i = 0; i < db.Length; i++)
                    {
                        for (int k = 1; k < db[i].nomera.Length; k++)
                        {
                            if ((db[i].nomera)[k].oper==oper){db[i].Print();}
                        }
                    }
                }

            }
        }
            static Abonent[] database()
            {
                Console.WriteLine("Введите количество элементов в бд");
                int l = Convert.ToInt32(Console.ReadLine());
                Abonent[] db = new Abonent[l];
                for (int i = 0; i<l; i++)
                {
                    Console.WriteLine("Введите ФИО");
                    string fio = Console.ReadLine();
                    Console.WriteLine("Введите город регистрации");
                    string city = Console.ReadLine();
                    Console.WriteLine("Введите количество номеров которыми владеет абонент");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Nomer[] nomera = new Nomer[c];
                    for (int j = 0; j < c; j++)
                    {
                        Console.WriteLine($"Заполнение номера {j+1}"); 
                        Console.WriteLine($"Введите номер телефона");
                        string number = Console.ReadLine();
                        Console.WriteLine("Введите оператора номера");
                        string oper = Console.ReadLine();
                        Console.WriteLine("Введите год регистрации номера");
                        string year = Console.ReadLine();
                        nomera[j] = new Nomer(number, oper, year);
                    }
                    db[i] = new Abonent(fio, city, nomera);
                    
                }
                return db;
            }

            static int menu(int flag)
            {
                Console.WriteLine("Меню:\n1) Заполнить бд\n2) Выборка по городу пдоключения\n3) Выборка по номеру телефона \n4) Выборка по оператору\n5)Выход");
                int choose = Convert.ToInt32(Console.ReadLine());
                if ((choose == 2 || choose == 3 || choose == 4) & flag == 0) {Console.WriteLine("Бд не заполнена!"); return 0;}
                else {return choose;}
            }
    }


    class Nomer
    {
        public string number;
        public string oper;
        public string year;
        

        public Nomer(string number, string oper, string year)
        {
            this.number = number;
            this.oper= oper;
            this.year = year;
            
        }

        public virtual void Show()
        {
            Console.WriteLine($"Номер: {number} Оператор: {oper} Год регистрации: {year}");
        }
    }
    class Abonent 
    {
        public string fio;
        public string city;
        public Nomer[] nomera;

        public Abonent(string fio, string city, Nomer[] nomera)
        {
            this.fio = fio;
            this.city = city;
            this.nomera = nomera;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Имя: {fio} Город регистрции {city}");
            for (int i=1; i < nomera.Length;i++)
            {nomera[i].Show();}
        }
    
    }
  
}    
    



