Console.WriteLine("Введите строку");
string inp = Convert.ToString(Console.ReadLine());

inp = inp.Replace("0", "").Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("+", "").Replace("-", "").Replace("*", "").Replace(":", "");
char[] inparr = inp.ToCharArray();
if (inparr[0] == '}' || inparr[0] == ')' || inparr[0] == ']') {Console.WriteLine("error");}
     
Stack<char> skobki = new Stack<char>();    
skobki.Push(inparr[0]);
for (int i = 1; i < inparr.Length; i++)
{
   char f = (char) skobki.Peek();
   Console.WriteLine(f);

}