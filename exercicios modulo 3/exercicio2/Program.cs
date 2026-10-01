namespace exercicio2;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Contagem Regressiva:{i}");
            if (i == 0)
            {
                Console.WriteLine("Fogo!!");
            }
        }
    }
}
