namespace SimuladorCarteiraDeInvestimentos;

class Program
{
    static void Main(string[] args)
    {
        Carteirta minhaCarteira = new Carteirta();


        minhaCarteira.MeusAtivos.Add(new FundoImobiliario("MXRF11", 1500.00));
        minhaCarteira.MeusAtivos.Add(new TesouroDireto("Tesouro Selic", 3000.00));

        double lucroProjetado = minhaCarteira.ProjetarRendimentos(12);

        Console.WriteLine($"O lucro projetado da sua carteira em 12 meses é de: R$ {lucroProjetado:F2}");
    }
}
