//CRIAR UM NOVO PROJETO CHAMADO DesafioParesImpares
// PERGUNTAR AO USUÁRIO QUANTOS NÚEMROS ELE QUER DIGITAR
//EXIBIR, SEPARADAMENTE, OS NÚMEROS PARES E OS NÚMEROS ÍMPARES QUE ELE DIGITAR
//EXEMPLO DE SAÍDA:
//Pares: 2, 4, 60, 200, 8
//Ímpares: 1, 3, 61, 209, 7


Console.WriteLine($"Quanto números você quer digitar?");
int qtdNumeros = int.Parse( Console.ReadLine() );
string pares = "Pares: ";
string impares = "Ímpares: ";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}º número:");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {//é par?
        pares += numeroDigitado.ToString() + ", ";//guarda o número como texto/string
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);
