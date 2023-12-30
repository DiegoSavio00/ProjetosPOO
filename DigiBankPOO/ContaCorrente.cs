using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBankPOO
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            NumeroDaConta = "00" + Conta.NumeroDaContaSequencial;
        }
    }
}
