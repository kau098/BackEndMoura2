namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Estoque;

        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            //imprimir os dados
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preco:F2}, Quantidade em estoue: {Estoque}");
        }
    }
}