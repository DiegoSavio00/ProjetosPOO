using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioFuncPOO
{
    public class Gerente : Funcionario
    {
        private double _pnl;

        public Gerente(string nome, double salario, double pnl) : base(nome, salario)
        {
            Pnl = pnl;
        }

        public double Pnl { get => _pnl; set => _pnl = value; }

        public override void CalcularPagamento()
        {
            Salario += Pnl;
        }
    }
}
