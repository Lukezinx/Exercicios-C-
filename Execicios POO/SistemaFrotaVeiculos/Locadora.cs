namespace LocadoraVeiculos;

public class Locadora
{
    private List<Veiculo> frota;

    public Locadora()
    {
        frota = new List<Veiculo>();
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        frota.Add(veiculo);
        Console.WriteLine($"O veículo de placa {veiculo.Placa} foi adicionado à frota.");
    }

    public void ListarVeiculosDisponiveis()
    {
        Console.WriteLine("--- Veículos Disponíveis para Aluguel ---");

        foreach (Veiculo v in frota)
        {
            if (!v.EstaManutencao)
            {
                Console.WriteLine($"Placa: {v.Placa} | Marca: {v.Marca} | Diária: R$ {v.ValorDiaria}");
            }
        }
    }


    public void AlugarVeiculo(String placa, int dias)
    {
        Veiculo veiculoEncontrado = null;

        foreach (Veiculo v in frota)
        {
            if (v.Placa == placa)
            {
                veiculoEncontrado = v;
                break;
            }
        }

        if (veiculoEncontrado == null)
        {
            Console.WriteLine($"Nenhum veículo encontrado com a placa {placa}.");
            return;
        }

        if (veiculoEncontrado.EstaManutencao)
        {
            Console.WriteLine($"O veículo {placa} está em manutenção e não pode ser alugado.");
            return;
        }

        double valorTotal = veiculoEncontrado.CalcularValorAluguel(dias);

        Console.WriteLine($"Veículo {placa} alugado por {dias} dias.");
        Console.WriteLine($"Valor total do contrato: R$ {valorTotal}");
    }
}