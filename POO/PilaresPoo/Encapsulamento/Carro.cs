namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual;

        // Set da Marca
        public void DefiniMArca(string valor)
        {
            Marca = valor;
        }
        // Get da Marca
        public string ObterMarca()
        {
            return Marca;
        }

        //    Set de Modelo
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        // Get de Modelo
        public string ObterModelo()
        {
            return Modelo;
        }

        // Get de VelocidadeAtual
        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }


        public void Acelerar(int valor)
        {
            if (valor > 0)
            {
                VelocidadeAtual += valor;
            } 
            else
            {
                Console.WriteLine($"Não pode acelerar negativamente!");
                    
            }
        }

        public void Frear(int valor)
        {

            if (valor > 0)
            {
                VelocidadeAtual -= valor;
            } 
            else
            {
                Console.WriteLine($"Não pode frear negativamente!");
            }
        }
    }
}