using System.ComponentModel.Design.Serialization;
using Calculadora;

Console.Clear();

Calculator calc = new Calculator();
// criar um menu de opções em loop
int opcao = -1;
do
{
    Console.Clear();
    // criar um cabeçalho de boas vindas
    Console.WriteLine($"==== Calculadora C# Console ====");
    Console.WriteLine();

    Console.WriteLine($"Menu");
    Console.WriteLine($"  1) Somar");
    Console.WriteLine($"  2) Subtrair");
    Console.WriteLine($"  3) Multiplicar");
    Console.WriteLine($"  4) Dividir");
    Console.WriteLine($"  0) Sair");
    Console.Write($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    
    // Pede os números ao usuário
    Console.WriteLine($"Digite o primeiro número");
    calc.Numero1 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo número");
    calc.Numero2 = int.Parse(Console.ReadLine());

    switch (opcao)
    {//roda a função que o usuário escolheu
        case 1:
            Console.WriteLine($"Resultado da soma: {calc.Somar()}");
            break;
        case 2:
            Console.WriteLine($"Resultado da subtração: {calc.Subtrair()}");
            break;
        case 3:
            Console.WriteLine($"Resultado da multiplicação: {calc.Multiplicar()}");
            break;
        case 4:
            Console.WriteLine($"Resultado da divisão: {calc.Dividir()}");
            break;
        case 0:
            Console.WriteLine($"Obrigado por utilizar o programa. Saindo ...");
            break;
        default:
            Console.WriteLine($"Opção Inválida, escolha uma opção de 1 a 4 ou 0 pra sair!");
            break;
    }

    Console.WriteLine($"Digite <Enter> para sair ...");
    Console.ReadLine();//para o programa aqui!
    
} while (opcao != 0);



// ajusatar o programa, conforme o menu, ou seja
// criar um switch 
// Menu:
//  1) Somar
//  2) Subtrair
//  3) Multiplicar
//  4) Dividir
// Você deve solicitar os dois números para o usuário e faze a conta conforme escolha do menu que
// o usuário fizer


// calc.Numero1 = 50;
// calc.Numero2 = 0;

// Console.WriteLine($"== Calculator ==");
// Console.WriteLine($"Primeiro número: {calc.Numero1}");
// Console.WriteLine($"Segundo número: {calc.Numero2}");

// Console.WriteLine($"Resultados:");
// Console.WriteLine();

// Console.WriteLine($"Soma {calc.Somar()}");
// Console.WriteLine();

// Console.WriteLine($"Subtração {calc.Subtrair()}");
// Console.WriteLine();

// Console.WriteLine($"Multiplicação {calc.Multiplicar()}");
// Console.WriteLine();

// Console.WriteLine($"Divisão {calc.Dividir()}");
// Console.WriteLine();


