
int contador = 1;

Console.WriteLine($"Quantas vezes você quer rodar o while?");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)
{
    Console.WriteLine($"Contador é: {contador}");
    contador++;
}
//fazer o exercício 27
// Faça um programa que pergunte para o usuário a quantidade de números que ele
// quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
// se for PAR. Utilize a estrutura WHILE.