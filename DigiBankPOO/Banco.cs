using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBankPOO
{
    public abstract class Banco
    {
        public string NomeDoBanco { get; private set; }
        public string CodigoDoBanco { get; private set; }

        public Banco()
        {
            NomeDoBanco = "DigiBank";
            CodigoDoBanco = "027";
        }
    }
}
