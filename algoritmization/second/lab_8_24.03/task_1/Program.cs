using System;
namespace Wtf
{
    class Programm
    {
        public static void Main()
        {
            Point up = new Point(10, 10);
            Point dw = new Point(-10, -10);
            Point ant = new Point(0,0);
            Rect xz = new Rect(up, dw, ant);
            Rect.isOut += print;
            xz.strt();
        }
        public void print(string message)
        {Console.WriteLine(message);}
        
    }
    class Rect
    {
        
        
        public Point upRight;
        public Point dwLeft;
        public Point ant;
        public delegate void isOut(string msg);
        public event isOut? Soo;
        public Rect(Point first, Point second, Point ant)
        {
            this.upRight = first;
            this.dwLeft = second;
            this.ant = ant;
        }

        public void strt()
        {
            int xx = ant.x;
            int yy = ant.y;
            Random rand = new Random();
            bool flg = false;
            while (flg == false)
            {
                xx = rand.Next(-1000, 1000); 
                yy = rand.Next(-1000, 1000);     
                ant.x = xx;
                ant.y = yy;
                flg = isIn();
             
            }
            Soo?.Invoke($"{xx}, {yy}");
            Console.WriteLine($"{xx}, {yy}");
        }
        public bool isIn()
        {
            if (ant.x<upRight.x && ant.x > dwLeft.x && ant.y<upRight.y && ant.y > dwLeft.y)
            {return false;}
            else {return true;}
             
        }
        
        
        }
    class Point
    {
        public int x;
        public int y;
               
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
          
        }
    }    

       
}

  