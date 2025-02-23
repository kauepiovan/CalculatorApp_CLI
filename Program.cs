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
        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("|                 CALCULADORA                |");
        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("");
        Console.WriteLine("Escolha a operação que deseja abaixo.");
        Console.WriteLine("");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracão");
        Console.WriteLine("3 - Multiplicacão");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("0 - SAIR DO PROGRAMA");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Digite o número da opção: ");
        Console.ReadLine();

        short operationNumber = short.Parse(Console.ReadLine());

        switch (operationNumber)
        {
            case 1:
            {
                Sum();
                break;
            }
            case 2:
            {
                Sub();
                break;
            }
            case 3:
            {
                Div();
                break;
            }
            case 4:
            {
                Mult();
                break;
            }
            case 0:
            {
                System.Environment.Exit(0);
                break;
            }
            default:
            {
                Menu();
                break;
            }
        }
 
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

        Console.ReadKey();
        Menu();
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

        Console.ReadKey();
        Menu();
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

        Console.ReadKey();
        Menu();
    }

    static void Mult()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 / num2;
        Console.WriteLine($"O resultado de {num1} * {num2} = {result}");

        Console.ReadKey();
        Menu();
    }
}
