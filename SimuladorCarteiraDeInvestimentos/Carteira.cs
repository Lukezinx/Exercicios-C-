public class Carteirta
{
    public List<IAtivosFinanceiros> MeusAtivos { get; set; } = new List<IAtivosFinanceiros>();

    public double ProjetarRendimentos(int meses)
    {
        return MeusAtivos.Sum(ativo => ativo.CalcularRendimentoMensal() * meses);
    }
}