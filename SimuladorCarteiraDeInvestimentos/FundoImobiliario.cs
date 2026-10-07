public class FundoImobiliario : IAtivosFinanceiros
{
    public string Nome { get; set; }

    public double ValorInvestido { get; set; }

    private double TaxaFixa = 0.01;


    public FundoImobiliario(string nome, double valorInvestido)
    {
        Nome = nome;
        ValorInvestido = valorInvestido;
    }

    public double CalcularRendimentoMensal()
    {
        return ValorInvestido * TaxaFixa;
    }
}