namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;
        public int Idade = 0;
        public int Altura;//em centímetros

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos!");
        }
        public void Dormir()
        {
            Console.WriteLine($"ZZZzzzz ...");
        }

        // se não treinar vai envelhercer mais rápido
        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {//adiciona a idade que foi recebida
                Idade += _id;
            }
            else
            {//adiciona apenas 1 ano na idade

                Idade++;
            }
        }
    }
}