using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioFuncPOO
{
    public class RelatorioPagamento
    {
        public static void RelatorioPegamentoGerente(Gerente gerente)
        {
            Console.WriteLine("Gerando relatório de pagamento para o Gerente.");
            gerente.CalcularPagamento();
            Console.WriteLine("Nome: " + gerente.Nome);
            Console.WriteLine("Salário: " + gerente.Salario);
        }

        public static void RelatorioPagamentoVendedor(Vendedor vendedor)
        {
            Console.WriteLine("Gerando relatório de pagamento para o Vendedor.");
            vendedor.CalcularPagamento();
            Console.WriteLine("Nome: " + vendedor.Nome);
            Console.WriteLine("Salário: " + vendedor.Salario);
        }

        public static void RelatorioPagamentoFuncionarios(Funcionario funcionario)
        {
            Console.WriteLine("Gerando relatorio de pagamento: ");
            funcionario.CalcularPagamento();
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Salário: " + funcionario.Salario);
            if (funcionario is Gerente)
            {
                Gerente g = (Gerente)funcionario;
                Console.WriteLine("Participação nos lucros: " + g.Pnl);
            }
            if (funcionario is Vendedor)
            {
                Vendedor v = (Vendedor)funcionario;
                Console.WriteLine("Total de vendas: " + v.TotalVendas);
            }
        }

    }
}
