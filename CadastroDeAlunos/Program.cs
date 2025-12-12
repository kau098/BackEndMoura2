//cria os dois arrays para cadastro dos alunos
string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;//controla a quantidade de alunos

int opcao;//opção
do
{
    Console.Clear();
    Console.WriteLine($"==== Aplicativo Sala de Aula ====");
    Console.WriteLine($"1) Listar Alunos");
    Console.WriteLine($"2) Cadastrar Alunos");
    Console.WriteLine($"0) Sair");
    Console.Write($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }
    // parada antes de recomeçar o menu
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();

} while (opcao != 0);

void ListarAluno()
{
    Console.WriteLine($"=== Listagem de Alunos ===");
    //exibir os nomes dos alunos
    for (int i = 0; i < totalAlunos; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}, {idades[i]} anos");
    }
}

void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastro de aluno ===");
    //verificar se eu posso cadastrar
    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;//pare a execução da função - retorna a função
    }

    //nome
    Console.WriteLine($"Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();//guarda o nome so aluno direto no array
    //idade
    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());//transforma a idade em número e guarda no array
    totalAlunos++;//atualiza a variável de controle de alunos
    Console.WriteLine($"Aluno cadastrado com sucesso!");
    
}