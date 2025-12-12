

namespace Construtores
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        
        public Carro(string marca, string modelo, int ano)
        {
            // preenchendo os dados iniciais na classe
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

            ExibirDados();//exive as informações da classe
        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo {Modelo}, Ano {Ano}");
            
        }
    }

}