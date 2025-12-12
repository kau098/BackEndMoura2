
namespace Exercicio02
{
    public class Funcionario
    {
        public string Nome;
        public float SalarioBase;

        public virtual float CalcularSalario()
        {
            return SalarioBase;
        }
    }
}