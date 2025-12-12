
int opcao;//variável de opção que será utilizada como condição o DO WHILE, deve ser criada fora do laço do while

do
{
    Console.Clear();//Limpa o console
    Console.WriteLine($"----------------------------------------------------------------");
    Console.WriteLine($"                        Bem Vindo                               ");
    Console.WriteLine($"                            ao                                  ");
    Console.WriteLine($"                       Jacareca Food                            ");
    Console.WriteLine($"----------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Escolha uma opção no menu abaixo:");
    Console.WriteLine();
    Console.WriteLine($"  1)  Hot Holl ............................ R$ 29,90");
    Console.WriteLine($"  2)  Temaki   ............................ R$ 30,00");
    Console.WriteLine($"  3)  Sashimi  ............................ R$ 67,20");
    Console.WriteLine($"  4)  Yakisoba ............................ R$ 35,90");
    Console.WriteLine($"  5)  Guioza   ............................ R$ 49,90");
    Console.WriteLine($"  6)  Shimeji  ............................ R$ 50,90");
    Console.WriteLine($"  0)  Sair");
    Console.Write($"Opção: ");// exibe o texto sem pular linha
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo ...");
            break;
        case 1:
            HotRoll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guioza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }//fim do switch

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine();//só pra parar o programa aqui
} while (opcao != 0);


void Shimeji()
{
    Console.WriteLine($@"
        Boa escolha, vamos 
        prepara seu Shimeji com 
        {5 * 2} 
        carinho
    ");
}

void Guioza()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Guioza com carinho");
}
void Yakisoba()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Yakisoba com carinho");
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Sashimi com carinho");
}
 void HotRoll()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu Hot Roll com carinho");
}

void Temaki()
{
Console.WriteLine(@$"
    Que só tem espaço
    Debaixo do tapete
    Você não tem culpa se ela não enxerga
    Um palmo à frente do nariz
    Mas, qualquer coisa, eu tô aqui
");
}