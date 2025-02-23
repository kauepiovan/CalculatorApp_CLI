using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu() 
    {
        Console.WriteLine("+--------------------------------------+");
        Console.WriteLine("|              CALCULADORA             |");
        Console.WriteLine("+--------------------------------------+");
        Console.WriteLine("");
        Console.WriteLine("Escolha a operacao que deseja abaixo");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Multiplicacao");
        Console.WriteLine("4 - Divisao");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Digite o numero da opcao: ");
        Console.ReadLine();
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
