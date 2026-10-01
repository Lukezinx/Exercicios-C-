using LocadoraVeiculos;

namespace SistemaFrotaVeiculos;

class Program
{
    static void Main(string[] args)
    {
        Locadora minhaLocadora = new Locadora();


        Carro c1 = new Carro("ABC-12345", "Chevrolet", "Onix", 2024, 150.00, 4);



        minhaLocadora.AdicionarVeiculo(c1);
        minhaLocadora.AlugarVeiculo("ABC-12345", 5);


        c1.RealizarManutencao();


        minhaLocadora.AlugarVeiculo("ABC-1234", 2);

    }
}
