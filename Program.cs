using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        
    }

    static void Sum() 
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"O resultado de {num1} + {num2} = {result}");
    }

    static void sub()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"O resultado de {num1} - {num2} = {result}");
    }

    static void div()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 / num2;
        Console.WriteLine($"O resultado de {num1} / {num2} = {result}");
    }

    static void mult()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"O resultado de {num1} * {num2} = {result}");
    }
}
