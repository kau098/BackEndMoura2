


using Exemplos;

// Gato birobinha = new Gato();
// Cachorro toto = new Cachorro();

// Crie uma classe Pessoa que herde de Animal
// Adicione as propriedades Nome e Idade
// Adicione o método Dormir()
// Crie um objeto da classe pessoa e 
// preencha as propriedades nome, idade e exiba os detalhes da pessoa no console

// Pessoa edu = new Pessoa();
// edu.Nome = "Eduardo Mendes";
// edu.Idade = 43;

// Console.WriteLine($"Nome: {edu.Nome}");
// Console.WriteLine($"Idade do {edu.Nome}: {edu.Idade} anos");

// Console.WriteLine($"Som do {edu.Nome}: ");
// edu.FazerSom();
// Console.WriteLine($"{edu.Nome} está se movendo: ");
// edu.Mover();

// Console.WriteLine($"{edu.Nome} foi dormir:");
// edu.Dormir();

// 2. Classe ContaBancaria
// Crie uma classe abstrata ContaBancaria com os métodos Depositar(double valor) e Sacar(double valor).
// Crie duas classes: ContaCorrente e ContaPoupanca, cada uma com sua própria forma de calcular o saldo após saque (por exemplo, taxa diferente).



Console.Clear();
Console.WriteLine($"CONTA CORRENTE:");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo após depósito: R${cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo após saque: R${cc.Saldo}");

Console.WriteLine();


Console.WriteLine($"CONTA POUPANÇA:");
ContaPoupanca cp = new ContaPoupanca(10);
Console.WriteLine($"Saldo inicial da poupança: R${cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo após o depósito: R${cp.Saldo}");
cp.Sacar(10.01);
Console.WriteLine($"Saldo após saque: R${cp.Saldo}");
