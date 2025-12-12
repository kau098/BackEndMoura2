//Pedir para o usuário digitar dois números e exibir a soma desses dois números

int n1, n2;
double batata;
Console.WriteLine($"Digite o primeiro número:");
// se o usuário digitar "40" o parse tira as aspas convertendo em número
n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número:");
n2 = int.Parse(Console.ReadLine());


int soma = n1 + n2;

Console.WriteLine($"A soma de {n1} + {n2} é {soma}");


