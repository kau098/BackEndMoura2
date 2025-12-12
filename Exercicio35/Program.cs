
// Faça um programa que solicite ao usuário um número de repetições “x”. Para cada
// repetição solicite dois números e imprima qual é o maior deles.

Console.WriteLine($"Quantos números você quer digitar");
// ciração das variáveis
int x = int.Parse(Console.ReadLine());
int n1, n2;
int contador = 1;

//laço de repetição - vai rodar de 1 até o número x que o usuário decidiu digitar
while (contador <= x)
{
    // pede os dois números
    Console.WriteLine($"Digite o primeiro número:");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo número:");
    n2 = int.Parse(Console.ReadLine());

    // verifica qual é o maior e exibe a mensagem para o usuário
    if (n1 > n2)
    {//primeiro é o maior
        Console.WriteLine($"O número {n1} é maior que {n2}");

    }
    else if (n2 > n1)
    {//segundo é o maior
        Console.WriteLine($"O número {n2} é maior que {n1}");
    }
    else
    {//os números são iguais

        Console.WriteLine($"{n1} e {n2} são iguais!");
    }

    contador++;//incrementa a variável contadora
}