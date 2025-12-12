namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";//quem está devendo ao credor
        public string Credor = "";//quem vai receber o valor 
        public float Valor = 0;//valor da fatura/boleto
        public int DiasAtraso = 0;
        private float Juros = 0.10f;

        // Construtor da classe
        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiasAtraso = qtdDiasAtraso;
        }

        public void  CalcularValorDivida()
        {
            if (DiasAtraso > 0)
            {
                Valor = Valor + DiasAtraso * Juros;
            }


            if(DiasAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }


        public void Imprimir()
        {
            CalcularValorDivida();
            
            Console.WriteLine($@"
    Credor: {Credor}
    Devedor: {Devedor}
    Dias de atraso: {DiasAtraso}
    Júros: R${Juros * DiasAtraso}
    Valor Total: R${Valor}
            ");
            
        }
        
    }
}