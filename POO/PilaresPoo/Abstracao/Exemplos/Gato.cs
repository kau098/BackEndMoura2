

using System.Diagnostics.Contracts;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Miau");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Ploc Ploc");
            
        }
    }
}