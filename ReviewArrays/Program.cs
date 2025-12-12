string[] nomes = new string[4];// array tamanho 4 - de 0 a 3

nomes[0] = "Edu";
nomes[1] = "Márcio";
nomes[2] = "Manoel";

Console.WriteLine($"Tamanho do Array: {nomes.Length}");

for (int i = 0; i < nomes.Length; i++)//roda de 0 a 3
{
    Console.WriteLine($"    {i + 1}o Nome: {nomes[i]}");
}

