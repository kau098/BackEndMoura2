

namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantas portas: {QtdPortas}");


        }
    }
}

// Criar um classe Moto e uma classe Aviao
// adicionar pelo menos 1 propriedade e um método que seja específico de cada um. Você deve aplicar a herança através da classe Veiculo
// criar um objeto de cada classe e utilzar seus métodos e propriedades