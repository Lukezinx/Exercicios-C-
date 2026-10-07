public class TesouroDireto : IAtivosFinanceiros
{
    public string Nome { get; set; }

    public double ValorInvestido { get; set; }

    public TesouroDireto(string nome, double valorInvestido)
    {
        Nome = nome;
        ValorInvestido = valorInvestido;
    }

    private double taxaFixaAno = 0.10;

    public double CalcularRendimentoMensal()
    {
        double taxaMensal = Math.Pow(1 + taxaFixaAno, 1.0 / 12.0) - 1;

        return ValorInvestido * taxaMensal;
    }
}