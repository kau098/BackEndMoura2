

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;
        public int Idade;
        public override void FazerSom()
        {
            Console.WriteLine($"Olá, eu sou uma pessoa feliz :)");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Plac Plac Plec");
            
        }


        public void Dormir()
        {
            Console.WriteLine($"ZZZzzzz ...");
            
        }
    }
}