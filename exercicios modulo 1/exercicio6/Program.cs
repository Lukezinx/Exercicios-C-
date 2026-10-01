namespace exercicio6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite 4 numeros:");
        int x1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"O resultado é {result:F2}");
    }
}
