using System.Security.AccessControl;

namespace exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a sua temperatura: ");
        int temp = int.Parse(Console.ReadLine());

        if (temp < 10)
        {

            Console.WriteLine("Frio");
        }
        else if (temp > 10 && temp < 25)
        {

            Console.WriteLine("Agradavel");
        }
        else
        {

            Console.WriteLine("quente");
        }
    }
}
