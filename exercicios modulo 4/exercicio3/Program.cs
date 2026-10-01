namespace exercicio3;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 10, 20, 15, 19, 40 };

        int maiorValor = array.Max();

        int indice = Array.IndexOf(array, maiorValor);

        Console.WriteLine(indice);
    }
}
