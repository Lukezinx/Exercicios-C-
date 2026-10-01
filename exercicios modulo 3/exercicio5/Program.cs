namespace exercicio5;

class Program
{
    static void Main(string[] args)
    {
        int sinal = 1;

        Console.Write("Digite um numero: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {

            int numeroComSinal = i * sinal;
            Console.WriteLine($"{numeroComSinal}");
            sinal *= -1;
        }
    }
}
