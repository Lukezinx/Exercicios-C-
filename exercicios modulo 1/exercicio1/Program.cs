using System.Globalization;

namespace exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero para calcular a temperatura");
        double number = double.Parse(Console.ReadLine());
        double calc = (number * 9 / 5) + 32;
        double result = Math.Round(calc, 3);
        Console.WriteLine($"A temperatura em Fahrenheit é: {result:F2}");
    }
}
