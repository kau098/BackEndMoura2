using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class ProdutoComDesconto
    {
        public string Nome = "";
        public double Preco;

        public void AplicarDesconto(double percentual)
        {
            if (percentual > 0 && percentual <= 50)
            {
                double valorDesconto = Preco * (percentual / 100);
                Preco -= valorDesconto;
                Console.WriteLine($"Desconto de {percentual}% foi aplicado, o preco atual eh R${Preco}");
            }
            else
            {
                Console.WriteLine($"Percentual de desconto invalido");
            }

        }
    }
}