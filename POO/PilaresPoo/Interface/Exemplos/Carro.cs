namespace Exemplos
{
    public class Carro : IMotor
    {
        // Propriedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        // Construtores
        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        // Métodos
        
        public void ExibirInfo()
        {
            Console.WriteLine($@"
Informações do Carro:
    Marca: {Marca}
    Modelo: {Modelo}
    Ano: {Ano}
    Cor: {Cor}
            ");
        }

        public void Acelerar()
        {
            
            Console.WriteLine($"Carro acelerando... Vrum Vrum");
            
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro Freiando... irrrrrrrrrrrrrrh");
            
        }
    }
}