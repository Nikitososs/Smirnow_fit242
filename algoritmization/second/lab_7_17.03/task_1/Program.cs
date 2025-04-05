using System;
using System.Collections.Generic;
namespace Wtf
{
    class Programm
    {
        public static void Main()
        {
            
            Console.WriteLine("Введите количество машин");
            int cnt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            string year = Console.ReadLine();
            Console.WriteLine("Введите марку");
            string name = Console.ReadLine();
            Console.WriteLine("Введите статус мойки");
            bool isClear = Convert.ToBoolean(Console.ReadLine());
            Car car = new Car(year, name, isClear);
            Garage garag = new Garage(car);
            
            for (int i = 0; i < cnt-1; i++)
            {
                
                Console.WriteLine("Введите год");
                year = Console.ReadLine();
                Console.WriteLine("Введите марку");
                name = Console.ReadLine();
                Console.WriteLine("Введите статус мойки");
                isClear = Convert.ToBoolean(Console.ReadLine());
                car = new Car(year, name, isClear);
                garag.carAdd(car);

            }
            garag.printGarage();
        }
    }
    delegate void wash(bool isClear)
    class Wash
    {
        public Wash(List<Car> carlist)
    }
    class Car
    {
        public string year;
        public string mark;
        public bool isClear;
               
        public Car(string year, string mark, bool isClear)
        {
            this.year = year;
            this.mark = mark;
            this.isClear = isClear;
           
        }
        public bool isc()
        {return isClear;}
        
        public void carPrint()
        {
            Console.WriteLine($"Год выпуска: {year}, Марка: {mark}, Чистая: {isClear}");
        }
    }    

    class Garage    
    {
        public List<Car> carsList;
        public Garage(Car car)
        {
            this.carsList = new List<Car>(){car};
        }
        
        public void carAdd(Car car)
        {
            this.carsList.Add(car);
        }
        public void printGarage()
        {
            for (int i = 0; i < carsList.Count; i++)
            {
                carsList[i].carPrint();
            }        
        }

    }
    
}

  