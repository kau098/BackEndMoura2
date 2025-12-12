namespace Calculadora
{
    public class Calculator
    {
        // atributos
        // Numero1, Numero2, Resultado do tipo Double
        public double Numero1;

        public double Numero2;
        public double Resultado;

        // métodos
        public double Somar()
        {
            Resultado = Numero1 + Numero2;
            return Resultado;
        }

        public double Subtrair()
        {
            Resultado = Numero1 - Numero2;
            return Resultado;
        }

        public double Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;

        }
        
        public double Dividir()
        {
            if (Numero2 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero");
                return -1;
            }
            
            Resultado = Numero1 / Numero2;
            return Resultado;
        }

    }
}