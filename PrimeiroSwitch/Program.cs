using System;

namespace PrimeiroSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
       string cargo;
    //    para limpar a tela do terminal, usaremos o comando Console.Clear()
    //    o comando Clear limpa a tela 
    Console.Clear();
    Console.WriteLine("Para saber o salário de um cargo, digite o cargo:");
    // O comando ToLower converte os caracteres para minúsculo
    cargo = Console.ReadLine().ToLower();

    switch(cargo){
        case "diretor":
        Console.WriteLine("O salário deste cargo é R$ 15.000.00");
        break;
        case "gerente":
        Console.WriteLine("O salário deste cargo é R$ 12.00.00");
        break;

        case "analista":
        Console.WriteLine("O salário deste cargo é R$ 8.000.00");
        break;
        
        case "assistente":
        Console.WriteLine("O salário deste cargo é R$ 4.00.00");
        break;

        case "auxuliar":
        Console.WriteLine("O salário deste cargo é R$ 2.000.00");
        break;
        
        default:
        Console.WriteLine("Não há salário");
        break;
    }
    }
    }
}
