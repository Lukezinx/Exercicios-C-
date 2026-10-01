public class Carro : Veiculo
{
    public int QuantidadeDePortas { get; set; }

    public Carro(string placa, string marca, string modelo, int ano, double valorDiaria, int quantidadeDePortas) : base(placa, marca, modelo, ano, valorDiaria)
    {
        this.QuantidadeDePortas = quantidadeDePortas;
    }

    public override double CalcularValorAluguel(int dias)
    {
        double valorTotal = dias * ValorDiaria;

        if (QuantidadeDePortas >= 4)
        {
            valorTotal = valorTotal + (valorTotal * 0.10);
        }

        return valorTotal;
    }
}