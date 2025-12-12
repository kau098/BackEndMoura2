namespace Heranca
{
    public class Gato : Animal
    {
        public string nome;
        public string raca;
        public int idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}, Raça {raca},Idade {idade}");


        }  
        public void FazerSom()
        {
            Console.WriteLine($"Miau");
            
        }
    }
}