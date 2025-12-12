namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 30;

        public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume Máximo atingido {NivelVolume}");
                return;//parar a execução do método por aqui
            }

            NivelVolume++;
            Console.WriteLine($"Volume: {NivelVolume}");
            
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV...");
            
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume já está no mínimo: {NivelVolume}");
                return;
            }

            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");
            
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV...");
        }
    }
}