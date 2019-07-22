using System;

namespace For1
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0;


           for(int e = 1;e <= 50;e++){
               if(e % 2 == 0){
                Console.WriteLine(e);
                qtd++;
               }
           }
           Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("Encontramos "+qtd+" Pares ");
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
