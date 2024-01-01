using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasPOO
{
    public class Piramide : Figura3D
    {
        private double _altura;
        private double _arestaBase;
        private double _apotema;
        private int _numPoliBase;

        private Figura2D _base;

        public double Altura { get => _altura; set => _altura = value; }
        public double ArestaBase { get => _arestaBase; set => _arestaBase = value; }
        public double Apotema { get => _apotema; set => _apotema = value; }
        public int NumPoliBase { get => _numPoliBase; set => _numPoliBase = value; }
        public Figura2D Base { get => _base; set => _base = value; }

        public new double CalcularArea()
        {
            if (Base != null)
                return ((NumPoliBase * (ArestaBase * Apotema) / 2) + base.CalcularArea());
            return 0;
        }

        public new double CalcularVolume()
        {
            if (Base != null)
                return (base.CalcularArea() * Altura) / 3;
            return 0;
        }

    }
}
