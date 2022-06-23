// Abaixo segue um exemplo de código que você pode ou não utilizar
using System; 

class Problem 
{
//TODO: Complete os espaços em branco com uma possível solução para o desafio
  static void Main(string[] args) 
  { 
    int N = int.Parse(Console.ReadLine());
    for (int i = N - 1; i > 0; i--)
    {
      N = N * i;
      //Console.WriteLine("{0} * {1} = {2}",N,i, N *  i);
    }
    Console.WriteLine(N);


      
  }
}
