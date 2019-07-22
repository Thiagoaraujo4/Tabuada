using System;

namespace For2
{
    class Program
    {
        static void Main(string[] args)
        {
       string nome = "";

       Console.WriteLine("Entre com um texto ");
       nome =Console.ReadLine();
        for (int i = 0; i <= nome.Length-1; i++){
            Console.WriteLine(nome[i]);
        } 
        }
    }
}
