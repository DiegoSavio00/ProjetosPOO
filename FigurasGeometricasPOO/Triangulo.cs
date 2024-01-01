using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasPOO
{
    public class Triangulo : Figura2D
    {
        private double _base;
        private double _altura;

        public double Base { get => _base; set => _base = value; }
        public double Altura { get => _altura; set => _altura = value; }

        public new double CalcularArea()
        {
            return (Altura * Base) / 2;
        }
    }
}
