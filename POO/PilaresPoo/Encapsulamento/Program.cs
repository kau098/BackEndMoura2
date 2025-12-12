using System.Net.Http.Headers;
using Encapsulamento;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria contaMaria = new ContaBancaria(1500);

contaEdu.Depositar(-100);
contaEdu.Depositar(20);
contaEdu.Sacar(-200);
contaMaria.Sacar(300);

Console.WriteLine();

Console.WriteLine($"Saldo atual do Edu: R${contaEdu.GetSaldo()}");
Console.WriteLine($"Saldo atual da Maria: R${contaMaria.GetSaldo()}");
