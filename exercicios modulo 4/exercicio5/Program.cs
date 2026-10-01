namespace exercicio5;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz =
        {
            {10,16,30},
            {1,2,36},
            {20,16,15},
        };

        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    soma += matriz[i, j];
                }
            }
        }

        Console.WriteLine(soma);
    }
}
