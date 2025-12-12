
namespace ExercicioPolimorfismo
{

   
    public class PagamentoPix : Pagamento
    {
        // desconto de 5%
        private float desconto = 5;
         public float ValorCompra;
         // Devolve o valor com desconto calculado
        public override float CalcularTotal()
        {
            float valorDesconto = ValorCompra / 100 * desconto;
            return ValorCompra = ValorCompra - valorDesconto;
        }
        
    }
}