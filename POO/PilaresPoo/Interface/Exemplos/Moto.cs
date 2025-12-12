
namespace Exemplos
{
    public class Moto : IMotor
    {
         // Propriedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        // Construtores
        public Moto(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }


        public void ExibirInfo()
        {
            Console.WriteLine($@"
Informações da Moto:
    Marca: {Marca}
    Modelo: {Modelo}
    Ano: {Ano}
    Cor: {Cor}
            ");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Acelerando a motoka");
            
        }

        public void Freiar()
        {
            Console.WriteLine($"Freiando a moto com ABS");
            
        }
    }
}