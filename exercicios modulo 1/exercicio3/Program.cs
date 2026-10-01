using System.Globalization;

namespace exercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o sua palavra");
        string text = Console.ReadLine();

        int newText = text.Trim().Length;
        Console.WriteLine(newText);
    }
}
