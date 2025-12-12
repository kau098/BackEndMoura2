using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;
float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: {compraPix.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Pix");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: {compraCartao.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Cartão");
Console.WriteLine($"Pagamento com Acréscimo: {compraCartao.CalcularTotal()}");
