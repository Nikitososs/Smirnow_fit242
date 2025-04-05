using System;
using System.Security.Cryptography;
namespace Wtf
{
    class Programm
    {
        public static void Main()
        {
            Nomer[] numbers = zapolny();
            Dictionary<string, int> operators = new Dictionary<string, int>(); 
            int mxcnt = 0; 
            for (int i = 0; i<numbers.Length; i++)
            {
                if (operators.ContainsKey(numbers[i].GetOper()))
                    {
                    int cnt = operators[numbers[i].GetOper()];
                    cnt += 1;
                    operators[numbers[i].GetOper()] = cnt;
                    mxcnt = Math.Max(cnt, mxcnt);                  }
                else {operators[numbers[i].GetOper()] = 1;}    
                
            }
            foreach(var oper in  operators)
            {
                if (oper.Value == mxcnt){Console.WriteLine(oper.Key);}
            }



        }
        static Nomer[] zapolny()
        {
            Console.WriteLine("Введите количество номеров");
            int count = Convert.ToInt32(Console.ReadLine());
            Nomer[] list = new Nomer[count];
            for (int i = 0; i<count; i++)
                {
                    Console.WriteLine("Введите номер");
                    string number = Console.ReadLine();
                    Console.WriteLine("Введите оператора");
                    string oper = Console.ReadLine();
                    list[i] = new Nomer(number, oper);
                }
            return list;
        }}
    class Nomer
    {
        public string number;
        public string oper;
               
        public Nomer(string number, string oper)
        {
            this.number = number;
            this.oper= oper;
           
        }
        public virtual void Print()
        {Console.WriteLine($"Номер: {number} Оператор: {oper}");}
        public virtual string GetOper()
        {return oper;}
    }    
    
}

  