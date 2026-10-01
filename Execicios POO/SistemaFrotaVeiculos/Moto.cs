public class Moto : Veiculo
{
    public int Cilindradas { get; set; }


    public Moto(string placa, string marca, string modelo, int ano, double valorDiaria, int cilindradas) : base(placa, marca, modelo, ano, valorDiaria)
    {
        Cilindradas = cilindradas;
    }

    public override double CalcularValorAluguel(int dias)
    {
        double valorTotal = dias * ValorDiaria;

        if (Cilindradas > 400)
        {
            valorTotal = valorTotal + (valorTotal * 0.15);
        }

        return valorTotal;
    }
}