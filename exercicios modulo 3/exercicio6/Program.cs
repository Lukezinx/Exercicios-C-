namespace exercicio6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        int n = int.Parse(Console.ReadLine());

        int n1 = 1;
        int n2 = 1;

        for (int i = 3; i <= n; i++)
        {
            int proximoTermo = n1 + n2;
            Console.Write($", {proximoTermo}");

            n1 = n2;
            n2 = proximoTermo;

        }
        Console.WriteLine();
    }
}
