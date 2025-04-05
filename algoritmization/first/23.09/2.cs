using System;
class HelloWorld {
  static void Main() {
    int a = -555, b = -35;
    int max = (System.Math.Abs(a-b)+(a+b))/2;
    int min = -(System.Math.Abs(a-b)-(a+b))/2;
    Console.WriteLine($"max={max}, min = {min}");
  }
}
