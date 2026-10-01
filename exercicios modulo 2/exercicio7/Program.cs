using System.Globalization;

namespace exercicio7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do produto");
        double number = double.Parse(Console.ReadLine());

        if (number >= 100 && number < 200)
        {
            double result = number * 0.1;
            result = number - result;
            Console.WriteLine($"o Resultado é: {result}");
        }
        else if (number >= 200)
        {
            double result = number * 0.15;
            result = number - result;
            Console.WriteLine($"o Resultado é: {result}");
        }
    }
}
