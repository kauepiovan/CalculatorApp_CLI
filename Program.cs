using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Sum();
        Sub();
        Div();
        Mult();
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

    static void Sub()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"O resultado de {num1} - {num2} = {result}");
    }

    static void Div()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 / num2;
        Console.WriteLine($"O resultado de {num1} / {num2} = {result}");
    }

    static void Mult()
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
