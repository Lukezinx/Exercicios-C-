using System.Numerics;

namespace incio;

class Program
{

    enum Dias { segunda, terça }
    static void Main(string[] args)
    {
        Console.Write("informação \n");
        Console.Write("Codigo \v");
        Console.WriteLine("Teste");


        // igual java menos o os Integer etc..
        string name = "Lucas";
        Console.WriteLine(name);

        // float f e decimal m -> float e decimal precisa de prefixo no final maiusculo ou minusculo
        float test = 2.3f;

        Console.WriteLine(test);

        //Operadores igual o de java e comcatenizaçao tambem

        int num1 = 2;
        int num2 = 3;
        int Resto = num1 + num2;

        //Interpolaçao de Strings
        Console.WriteLine($"Div. Inteira = {num1} + {num2} = {Resto}");

        // ler dados Read apenas caracteres, ReadLine linha inteira
        string number = Console.ReadLine();
        int numberFormat = string.Parse(number);
        Console.WriteLine("seu numero é: " + numberFormat);

        // exite int.Parse e Convert.ToInt32 e os outros para as outras, como int64 que seria o float, tem para decimal, char etc.. 

        Dias dias = Dias.segunda;



    }
}
