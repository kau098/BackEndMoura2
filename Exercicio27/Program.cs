int qntdUsuario = 0;
int contador = 1;
Console.WriteLine("Quantos Numeros Voce Quer Digitar");
qntdUsuario = int.Parse(Console.ReadLine());

while (contador <= qntdUsuario)
{
    Console.WriteLine($"Digite Um Numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero Digitado eh Par: {batata}");
    }
    contador++;
}