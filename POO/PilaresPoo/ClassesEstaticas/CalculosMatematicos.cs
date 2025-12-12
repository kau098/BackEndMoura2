

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        public static double PI = 3.14159265359;

        public static float Somar(float x, float y)
        {
            return x + y;
            
        }
        public static float Subtrair(float x, float y)
        {
            return x - y;
            
        }
        public static float Multiplicar(float x, float y)
        {
            return x * y;
            
        }
        
        public static float Dividir(float x, float y)
        {
            if (y == 0)
            {
                Console.WriteLine($"Divisão inválida");
                
            }
            return x / y;
            
        }
    }
}