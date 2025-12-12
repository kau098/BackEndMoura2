namespace Heranca
{
    public class Cachorro
    {
        public string nome;
        public string raca;
        public int idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome{nome}, Raça{raca}, Idade{idade}");


        }
        
        public void FazerSom()
        {
            Console.WriteLine($"au au");
            
        }

    }
}