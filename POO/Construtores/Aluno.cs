namespace Construtores
{
    public class Aluno
    {

        //Propriedades
        public string Nome;

        public int Nota;


        //Construtores
        public Aluno()
        {
            Console.WriteLine($"Lista de alunos:");
        }

        public Aluno(string n, int m)
        {
            Nome = n;
            Nota = m;
        }

        //Método 
        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome} | Nota: {Nota}");

        }
    }
}