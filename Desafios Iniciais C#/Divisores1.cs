// Abaixo segue um exemplo de código que você pode ou não utilizar

using System;

class MainClass 
{
  public static void Main(string[] args) 
  {
    var n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++) 
    {
        if (n % i == 0)
        {
          Console.WriteLine(i);
        }
    }
    Console.WriteLine();
  }
}
