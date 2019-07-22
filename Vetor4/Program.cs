using System;

namespace Vetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] valores ={3, 15, 98, 10, 0, 78, 45, 13};

            int maior = valores [0];

            for(int x = 1; x < valores.Length; x++){
                if(valores[x]>maior){
                    maior=valores[x];
                }
            }
            Console.WriteLine("O maior valor do vetor é: "+maior);

            int menor = valores [0];

            for(int x = 1; x < valores.Length; x++){
                if(valores[x] < menor){
                    menor=valores[x];
                }
            }
            Console.WriteLine("O menor valor do vetor é: "+menor);
        }
    }
}
