using System;

namespace Vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] numeros = {39, 0, 5, 1, 3, 10, 4};
          int v =5;
          int n;
          for (n= 0; n <= 6;n++)
          {
            if (numeros[n]==v)
          {
            Console.WriteLine(n);
          }
        }
        }
        
    }
}
