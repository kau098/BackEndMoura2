using PrimeiraClasse;

// Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// // Carro mclaren = new Carro();
// // mclaren.marca = "Mclaren";
// // mclaren.cor = "Laranja";
// // mclaren.modelo = "750s";
// // mclaren.potencia = 800;

// // Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// // mclaren.Ligar();
// // Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// // mclaren.Acelerar();


// // Pessoa edu = new Pessoa();
// // edu.Nome = "Eduardo Mendes";
// // edu.Idade = 43;
// // edu.Altura = 166;

// // edu.Falar();
// // edu.Dormir();

// Garrafa Tupperware = new Garrafa();
// Tupperware.Cor = "Roxa";
// Tupperware.Capacidade = 500;
// Tupperware.Tamanho = 27;
// Tupperware.Formato = "Arrendondada";
// Tupperware.Abrir();
// Tupperware.Beber();

// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Azul Goiaba";
// Stanley.Capacidade = 500;
// Stanley.Formato = "Cilíndrico";
// Stanley.Tamanho = 20;
// Console.Write($"Abrindo a garrafa Stanley: ");
// Stanley.Abrir();

// Console.Write($"Bebendo água da garrafa Stanley: ");
// Stanley.Beber();

Console.Clear();
Pessoa edu = new Pessoa();
edu.Nome = "Eduardo Mendes";
edu.Altura = 166;
edu.Envelhecer();//1

Console.WriteLine($"{edu.Nome} tem {edu.Idade} ano(s)");
edu.Envelhecer(10);
Console.WriteLine($"{edu.Nome} tem {edu.Idade} ano(s)");
