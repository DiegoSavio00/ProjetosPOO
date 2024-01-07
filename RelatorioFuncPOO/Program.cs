// See https://aka.ms/new-console-template for more information
using RelatorioFuncPOO;

Console.WriteLine("Hello, World!");

Gerente g = new Gerente("Jose", 3000, 1000);
Vendedor v = new Vendedor("Luana", 2200, 1200);
RelatorioPagamento.RelatorioPegamentoGerente(g);
Console.WriteLine("========================");
RelatorioPagamento.RelatorioPagamentoVendedor(v);
Console.WriteLine("========================");

Console.WriteLine("=============================================");

Gerente g1 = new Gerente("Luan", 3200, 1100);
Vendedor v1 = new Vendedor("Carla", 2400, 1000);
RelatorioPagamento.RelatorioPagamentoFuncionarios(g1);
Console.WriteLine("=========================");
RelatorioPagamento.RelatorioPagamentoFuncionarios(v1);

Funcionario f = g;
Console.WriteLine(f.Salario);
