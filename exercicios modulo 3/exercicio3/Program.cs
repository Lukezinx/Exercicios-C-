using System.Globalization;

namespace exercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {i * number}");
        }

    }
}
