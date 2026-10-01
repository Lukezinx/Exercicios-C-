namespace exercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite as 3 notas");
        decimal number1 = decimal.Parse(Console.ReadLine());
        decimal number2 = decimal.Parse(Console.ReadLine());
        decimal number3 = decimal.Parse(Console.ReadLine());

        decimal result = (number1 + number2 + number3) / 3m;

        Console.WriteLine($"A sua media é: {result:F2}");
    }
}
