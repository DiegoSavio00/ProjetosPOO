using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBankPOO
{
    public abstract class Conta : Banco, IConta
    {
        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroDaConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        private List<Extrato> Movimentacoes;

        public Conta()
        {
            NumeroAgencia = "001";
            Conta.NumeroDaContaSequencial++;
            Movimentacoes = new List<Extrato>();
        }

        public string BuscarCodigoDoBanco()
        {
            return CodigoDoBanco;
        }

        public string BuscarNumeroDaAgencia()
        {
            return NumeroAgencia;
        }

        public string BuscarNumeroDaConta()
        {
            return NumeroDaConta;
        }

        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public void Depositar(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            Movimentacoes.Add(new Extrato("Deposito", valor, dataAtual));
            Saldo += valor;
        }

        public List<Extrato> Extatos()
        {
            return Movimentacoes;
        }

        public bool Sacar(double valor)
        {
            if (valor > ConsultarSaldo()) return false;
            DateTime dataAtual = DateTime.Now;
            Movimentacoes.Add(new Extrato("Saque", -valor, dataAtual));
            Saldo -= valor;
            return true;
        }
    }
}
