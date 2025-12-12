//Exibir os números ímpares de 0 a 50 com o laço for
for (int i = 1; i < 50; i += 2)
{
    Console.WriteLine($"Valor do i: {i}");
}

for (int i = 0; i <= 50; i++)
{
    if(i % 2 == 1)
    {
        Console.WriteLine($"Número Ímpar: {i}");
        
    }
}