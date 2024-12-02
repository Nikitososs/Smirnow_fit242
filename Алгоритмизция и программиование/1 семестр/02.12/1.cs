using System;
namespace Wtf
{
    class Xz
    {
        public int x;
        public int y;


        public Xz()
        {
            x = 0;
            y = 0;
        }

        public Xz(int x)
        {
            this.x = x;
            y = 0;
        }

        public Xz(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Plus()
        {
            Console.WriteLine(x+y);
        }

        public void Minus(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public void Del(int a, int b)
        {
            if (b!=0){Console.WriteLine(a/b);}
            else {Console.WriteLine("Дел на 0");}
        }

        public void Multi()
        {
            Console.WriteLine(x*y);
        }
    }
    class Program
    {
        public static void Main()
        {
            Xz a = new Xz();
            a.Plus();
            a.Minus(a.x, a.y);
            a.Del(a.x, a.y);
            a.Multi();

            int x = Convert.ToInt32(Console.ReadLine());
            Xz b = new Xz(x);
            b.Plus();
            b.Minus(b.x,b.y);
            b.Del(b.x,b.y);
            b.Multi();

            x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Xz c = new Xz(x,y);
            c.Plus();
            c.Minus(c.x,c.y);
            c.Del(c.x,c.y);
            c.Multi();
        }

    }

}
