//Pedir para o usuário digitar o nome, sobrenome, idade, saldo bancário e quanto investiu esse ano

//Camel Case - Letra maiúscula a partir da segunda palavra
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

//Pasca Case - Primeira letra de cada palavra sempre maiúscula
Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse( Console.ReadLine() );//converte o texto em int antes de jogar na variável

Console.WriteLine("Qual é o saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine());//converte o texto digitado no console em float

Console.WriteLine("Qual é investimento para este ano?");
investimentos = float.Parse(Console.ReadLine());//converte o texto digitado no console em float

Console.Clear();//limpa o console

Console.WriteLine("Saída de Dados:");
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo Bancário: R${saldoBancario}");
Console.WriteLine($"Investimento este ano: R${investimentos}");



