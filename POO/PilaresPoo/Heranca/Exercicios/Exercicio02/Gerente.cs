

namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public float Bonus;

        public override float CalcularSalario()
        {//retorna o salario base + bônus
            return SalarioBase += Bonus;
        }
    }
}