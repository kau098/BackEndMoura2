//importa todas as classes da pasta/namespace
using System.Data;
using ClasseEObjetos;

// Console.Clear();
// Console.WriteLine($"== Agência Bancária ==");
// Console.WriteLine();

// AgenciaBancaria contaDoJoao = new AgenciaBancaria();

// contaDoJoao.Titular = "Diogo Farias";
// contaDoJoao.Saldo = 1000.98f;

// contaDoJoao.Depositar(-5000);

// contaDoJoao.Sacar(90000);

Console.Clear();
ProdutoComDesconto panela = new ProdutoComDesconto();
panela.Nome = "Panela de Pressao Tramontina";
panela.Preco = 100;

Console.WriteLine($"{panela.Nome} custa R${panela.Preco}");

panela.AplicarDesconto(51);
