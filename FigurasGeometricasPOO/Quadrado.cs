using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasPOO
{
    public class Quadrado : Figura2D
    {
        private int _lado;

        public int Lado { get => _lado; set => _lado = value; }

        public new double CalcularArea() => Math.Pow(Lado, 2);
    }
}
