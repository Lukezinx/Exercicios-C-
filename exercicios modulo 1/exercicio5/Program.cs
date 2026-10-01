using System.Reflection;

namespace exercicio5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        double number = double.Parse(Console.ReadLine());
        double min = number * 60;
        double sec = number * 3600;

        Console.WriteLine($"os Minutos são {min}m e os segundos {sec}s");
    }
}
