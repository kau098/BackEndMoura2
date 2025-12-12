// Exercício 2 – Funcionários de uma empresa
// Crie uma classe Funcionario com as propriedades Nome e SalarioBase.
// Crie uma classe Gerente que herde de Funcionario e possua um bônus adicional.
// Implemente um método CalcularSalario() que retorne o salário total considerando o bônus do gerente.
// Crie objetos das duas classes e exiba os salários no console.

// Funcionario
// Nome
// Salario
// CalcularSalario()
// Gerente
// Bonus
// CalcularSalario()


using Exercicio02;

Funcionario funComum = new Funcionario();
Gerente gerente = new Gerente();

funComum.SalarioBase = 1000;
gerente.SalarioBase = 10000;

float SalFinalComum = funComum.CalcularSalario();
float SalFinalGer = gerente.CalcularSalario();

Console.WriteLine($"Salario do Funcionário: {SalFinalComum}");
Console.WriteLine($"Salario do Gerente: {SalFinalGer}");
