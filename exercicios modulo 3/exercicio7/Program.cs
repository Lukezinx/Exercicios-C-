using System.Globalization;

namespace exercicio7;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 0; i < 50; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
