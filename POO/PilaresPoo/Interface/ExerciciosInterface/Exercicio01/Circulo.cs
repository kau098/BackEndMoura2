namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        public void CalcularArea()
        {
            float area = (float)Math.PI * Raio * Raio;
            Console.WriteLine($"A área do circulo é: {area}");
        }
    }
}