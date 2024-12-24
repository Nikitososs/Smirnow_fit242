using System;
namespace Wtf
{
    class Programm
    {
        public static void Main()
        {
            int flag = 0;
            int x = 0;
            Pupil[] db = null;

            while (x!=4)
            {
                x = menu(flag);
                if (x == 1)
                {
                    flag = 1;
                    db = database();
                }
                else if (x == 2)
                {
                    Console.WriteLine("Введите год");  
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выборка по году:");
                    for (int i = 0; i < db.Length; i++)
                    {
                        if (db[i].birth_date == year)
                        {
                            db[i].Print();
                        }
                    }
                }
                else if (x == 3)
                {
                    Console.WriteLine("Введите класс");  
                    string clas = Console.ReadLine();
                    Console.WriteLine("Выборка по классу:");
                    for (int i = 0; i < db.Length; i++)
                    {
                        if (db[i].clas == clas)
                        {
                            db[i].Print();
                        }
                    }
                }
            }
        }
            static Pupil[] database()
            {
                Console.WriteLine("Введите количество элементов в бд");
                int l = Convert.ToInt32(Console.ReadLine());
                Pupil[] db = new Pupil[l];
                for (int i = 0; i<l; i++)
                {
                        Console.WriteLine("Введите ФИО");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите год рождения");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите класс");
                        string clas = Console.ReadLine();
                        Console.WriteLine("Введите номер");
                        string number = Console.ReadLine();
                        
                        db[i] = new Pupil(fio, year, clas, number);
                }
                return db;
            }

            static int menu(int flag)
            {
                Console.WriteLine("Меню:\n1) Заполнить бд\n2) Выборка по году рождения \n3) Выборка по классу \n4) Выход");
                int choose = Convert.ToInt32(Console.ReadLine());
                if ((choose == 2 || choose == 3) & flag == 0) {Console.WriteLine("Бд не заполнена!"); return 0;}
                else {return choose;}
            }
    }


    class Pupil {
        private string _fio;
        public string fio {get {return _fio;}}

        private int _birth_date;
        public int birth_date {get {return _birth_date;}}

        private string _clas;
        public string clas {get {return _clas;}}

        private string _number;
        public string number {get {return _number;}}

        public Pupil(string _fio, int _birth_date, string _clas, string _number)
        {
            this._fio = _fio;
            this._birth_date = _birth_date;
            this._clas = _clas;
            this._number = _number;
        }

        public virtual void Print()
        {
            Console.WriteLine($"ФИО: {_fio} Год рождения: {_birth_date} Класс: {_clas} Номер: {_number}");
        }
    }
}
