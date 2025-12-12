namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;

    

        public void Imprimir()
        {
            Console.WriteLine($@"
    Contratante: {Nome}
    Cláusulas: {TextoClausulas}    
        ");
        }
    }
}


// Fazer a funcão de cadastrar e listar de contratos e relatórios.