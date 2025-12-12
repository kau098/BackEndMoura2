using Exercicio01;

Console.Clear();
Console.WriteLine($"-- Bem vindo ao programa de Geometria --");
Console.WriteLine();

// ----------- RETÂNGULO ----------- 
Console.WriteLine($"Vamos calcular a área do retângulo:");

Console.Write($"Informe a altura: ");
float altura = float.Parse(Console.ReadLine());
Console.Write($"Informa a largura: ");
float largura = float.Parse(Console.ReadLine());

//cria a variável objeto da classe Retangulo
Retangulo retangulo = new Retangulo(largura, altura);
Console.WriteLine();

// ----------- CÍRCULO ----------- 
Console.WriteLine($"Agora vamos calcular a área do círculo");
Console.WriteLine($"Informe o raio do círculo");
float raio = float.Parse(Console.ReadLine());

//cria a variável objeto da classe Circulo
Circulo circulo = new Circulo();
circulo.Raio = raio;

// ----------- RESULTADOS ----------- 
Console.WriteLine();

retangulo.CalcularArea();
circulo.CalcularArea();
