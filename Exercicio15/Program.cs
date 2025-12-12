// Faça um programa que receba 4 notas de um aluno, calcule e imprima a média
// aritmética das notas e a mensagem de APROVADO para média superior ou igual a
// 7,0 RECUPERAÇÃO para notas entre 5.0 e 7,0 ou a mensagem de REPROVADO
// para média inferior a 5,0.


float n1, n2, n3, n4, media;

Console.WriteLine($"Digite o primeiro número");
n1 = float.Parse( Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
n2 = float.Parse( Console.ReadLine());

Console.WriteLine($"Digite o terceiro número");
n3 = float.Parse( Console.ReadLine());

Console.WriteLine($"Digite o quart número");
n4 = float.Parse( Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4; 

Console.WriteLine($"Média: {media}");


if (media >= 7)
{
    Console.WriteLine($"Aprovado");

}
else if (media >= 5)
{
    Console.WriteLine($"Recuperação");

}
else
{
    Console.WriteLine("Reprovado");
}