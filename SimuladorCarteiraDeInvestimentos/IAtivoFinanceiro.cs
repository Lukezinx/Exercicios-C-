public interface IAtivosFinanceiros
{

    string Nome { get; }
    double ValorInvestido { get; }

    public double CalcularRendimentoMensal();
}