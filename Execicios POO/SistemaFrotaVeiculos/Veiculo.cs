using manutancao;

public abstract class Veiculo : IManutencao
{
    public string Placa { get; protected set; }
    public string Marca { get; protected set; }
    public string Modelo { get; protected set; }
    public int Ano { get; protected set; }
    public double ValorDiaria { get; protected set; }

    protected Veiculo(string placa, string marca, string modelo, int ano, double valorDiaria)
    {
        this.Placa = placa;
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
        this.ValorDiaria = valorDiaria;
    }

    public bool EstaManutencao { get; private set; } = false;

    public abstract double CalcularValorAluguel(int dias);

    public void RealizarManutencao()
    {
        EstaManutencao = true;
        Console.WriteLine("Veiculo esta em manutanção");
    }
}