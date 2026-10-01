namespace exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero:");
        int number = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 1; i < number; i++)
        {
            if (i % 2 == 0)
            {
                result += i;

            }
        }
        Console.WriteLine($"A soma é: {result}");
    }
}
