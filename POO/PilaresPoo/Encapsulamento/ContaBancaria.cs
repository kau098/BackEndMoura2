namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;


        public ContaBancaria()
        {
            Saldo = 0;
        }
        
        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }


        // Métodos Gets and Set


        // Set do Saldo
        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor Inválido");
            }
            else
            {
                Saldo += valor;
            }
        }

        // Get do Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo!");
            }

        }
    }
}