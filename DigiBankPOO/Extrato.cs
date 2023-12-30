using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBankPOO
{
    public class Extrato
    {
        public Extrato(string descricao, double valor, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }

        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }

    }
}
