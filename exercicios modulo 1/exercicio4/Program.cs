using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace exercicio4;

class Program
{

    static void Main(string[] args)
    {
        var pi = Math.PI;
        Console.WriteLine("digite um numero para calcular o raio e a Área");
        double number = double.Parse(Console.ReadLine());
        double raio = number / (2 * pi);

        double result = pi * Math.Pow(raio, 2);

        Console.WriteLine($"O resultado da conta é: {result:F2}");
    }
}
