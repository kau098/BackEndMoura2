string[] nomes = new string[10];//array tamanho 10 - de 0 a 9
float[] saldos = new float[10];//array tamanho 10 - de 0 a 9
int totalClientes = 0;//controle a quantidade de cadastros

int opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"=== SISTEMA BANCÁRIO SIMPLES ===
1. Cadastrar Cliente
2. Depositar
3. Sacar
4. Transferir
5. Listar Clientes
0. Sair");
    Console.Write($"Digite a opção: ");
    opcao = int.Parse(Console.ReadLine());

    // switch
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa ...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarCliente();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }//fim do switch

    //ao final de cada opção, faz uma parada no sistema
    Console.WriteLine("Pressione <ENTER> para continuar...");
    Console.ReadLine();

} while (opcao != 0);//recomeça o menu

//fim do programa


// Funçõeas 

void CadastrarCliente()
{
    // validar se há espaço pra cadastrar no array
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;// para a função aqui - não executa o código abaixo
    }

    // cadastrar o cliente no array - 0
    Console.Write($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();//cadastra o nome do cliente
    saldos[totalClientes] = 0;//inicia o saldo zerado
    totalClientes++;//incrementa a variável de controle de clientes
    Console.WriteLine("Cliente cadastrado com sucesso!");
}

void Depositar()
{
    //retorna o índice do array onde o cliente está armazenado
    // assim eu posso usar de base para guradar o saldo do cliente
    int idCliente = BuscarCliente();

    if (idCliente == -1)
    {//cliente não encontrado
        return;//para a função
    }

    // cliente encontrado
    Console.Write($"Valor para depósito: ");
    float valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += valor;
    Console.WriteLine($"Depósito de R$ {valor:F2} realizado");
}

void Sacar()
{
    int idCliente = BuscarCliente();// buscar o cliente (lista e devolve o id do cliente)
    if (idCliente == -1)
    {//cliente não existe
        return;
    }
    
    //cliente existe
    Console.Write($"Valor para saque: ");
    float valor = float.Parse(Console.ReadLine());//armazena o valor do salque na variável valor

    // se o saldo do cliente for maior ou igual ao valor e não pode ser valor negativo
    if (saldos[idCliente] >= valor && valor > 0)
    {//tem saldo suficiente, então pode sacar
        saldos[idCliente] -= valor; //depita o valor da conta/saldo do cliente
        Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!");
    }
}//fim da função Sacar

void Transferir()
{
    Console.WriteLine($"== Transferência ==");
    Console.Write($"Conta de Origem: ");
    int idOrigem = BuscarCliente();//lista e retorna o id do cliente que o usuário escolher

    if (idOrigem == -1) return; //cliente não existe

    Console.Write($"Conta de Destino: ");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return; //cliente não existe

    Console.Write($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());


    if (saldos[idOrigem] >= valor && valor > 0)
    {//deixa sacar apenas se for número positivo e se tem dinheiro o sufuciente
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor;
        Console.WriteLine($"Transferência concluída!");
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!");
    }
}

void ListarCliente()
{
    Console.WriteLine("== Lista de Clientes ==");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nomes[i]} | Saldo: R$ {saldos[i]}");
    }
}

int BuscarCliente()
{
    //listar cliente
    ListarCliente();//mostra a lista de clientes
    //pedir pro usuário escolher o cliente 
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado!");
        return -1;
    }

    //retornar/devolver o id do cliente
    return idCliente;
}