// Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo,
// disposto na tabela abaixo

// Produção - 6.5
// Admnistrativo - 7.5
// Diretoria - 12

// salario = salario * 1.065
// salario = salario * 1.075
// salario = salario * 1.12

// De acordo com a tabela acima faça um programa que receba o cargo e o salário de um funcionário e calcule e imprima o salário reajustado.

string cargo;
float salario, salarioNovo = 0;

Console.WriteLine($"Digite o cargo do funcionario producao, administrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"digite o salario do funcionario");
salario = float.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065f);

}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075f);

}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12f);
}

else
{
    Console.WriteLine($"Cargo invalido");
}

Console.WriteLine($"o novo salario reajustado e {salarioNovo }" );


