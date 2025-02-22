using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Digite um valor: ");
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("\nDigite outro valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        
        Console.WriteLine($"\nO resultado de {v1} + {v2} = {resultado}");

        
    }
}
