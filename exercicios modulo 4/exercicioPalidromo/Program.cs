namespace exercicioPalidromo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero inteiro");
        string numero = Console.ReadLine();

        char[] digitos = numero.ToCharArray();
        bool palindromo = false;

        for (int i = 0; i < digitos.Length; i++)
        {
            char[] temp = (char[])digitos.Clone();
            Array.Reverse(temp);
            if (temp[i] == digitos[i])
            {
                palindromo = true;
            }
            else
            {
                palindromo = false;
            }


        }

        if (palindromo)
        {
            Console.WriteLine("Este numero é um palidromo");
        }
        else
        {
            Console.WriteLine("Este numero não é um palidromo");
        }
    }
}
