using System;
class Prog {
  static void Main() {
    int a = 1;
    int b = 2;
    Console.WriteLine($"a={a}, b={b}");
    a = a+b;
    b = a-b;
    a = a-b;
    Console.WriteLine($"a={a}, b={b}");

  }
}
