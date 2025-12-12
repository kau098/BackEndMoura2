
namespace Exemplos
{

    // implementar o método sacar com 3% de taxa
    public class ContaPoupanca : ContaBancaria
    {
        // Propriedades da classe
        public double Saldo = 0;
        private double TaxaSaque = 3;//3% de taxa de saque


        // Método construtor da classe
        public ContaPoupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        // Métodos comuns

        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
                return;//para a execução do método aqui
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {

            double totalComTaxa = (valor / 100 * TaxaSaque) + valor;

            if (valor <= 0 || Saldo < totalComTaxa)
            {//não pode sacar
                //debita da conta
                Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro na conta");
                return;
            }

            Saldo -= totalComTaxa;//efetua o saque
        }
    }
}