
namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float Largura;
        public float Altura;

        // construtor

      
        public Retangulo(float largura, float altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public void CalcularArea()
        {
            float area = Largura * Altura;
            Console.WriteLine($"Área do retângulo: {area}");
        }
    }
}