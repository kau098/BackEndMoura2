// 1) Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

double salarioRecebido, totalGasto;

Console.WriteLine($"Informe o salário: ");
salarioRecebido = double.Parse(Console.ReadLine());
Console.WriteLine($"Informe o gasto do mês: ");
totalGasto = double.Parse(Console.ReadLine());

if (totalGasto > salarioRecebido)
{
    Console.WriteLine($"Orçamento Estourado!");
}
else
{
    Console.WriteLine($"Gastos dentro do Orçamento!");
}
