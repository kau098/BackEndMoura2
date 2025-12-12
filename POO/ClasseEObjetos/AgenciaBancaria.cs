
namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        // Propriedades/Atributo
        public string Titular;
        public float Saldo;

        // Métodos
        public void Depositar(float valor)
        {
            if (valor > 0)
            {

                Saldo += valor;//adiciona um valor ao saldo
                Console.WriteLine($"Depósito efetuado com sucesso!");
                Console.WriteLine($"Novo Saldo: R${Saldo:F2}");
            }
            else
            {
                Console.WriteLine($"O valordo depósito deve ser positivo");
                Console.WriteLine($"Saldo: {Saldo:F2}");
            }
        }//fim do método depositar


        public void Sacar(float valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;//debita o valor do saldo
                Console.WriteLine($"Saque realizado com sucesso!");
                Console.WriteLine($"Novo Saldo: {Saldo:F2}");
                return;
            }

            Console.WriteLine($"Saldo insuficiente");
            Console.WriteLine($"Saldo: {Saldo:F2}");
        }
    }//fim da classe
}//fim do namespace