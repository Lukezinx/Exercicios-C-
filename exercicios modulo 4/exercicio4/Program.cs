namespace exercicio4;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 3, 40, };
        int soma = 0;

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                soma += numero;
            }
        }
        Console.WriteLine($"A soma total é: {soma}");
    }
}
