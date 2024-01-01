namespace FigurasGeometricasPOO
{
    public class Cilindro : Figura3D
    {
        private double _raio;
        private double _altura;

        public double Raio { get => _raio; set => _raio = value; }
        public double Altura { get => _altura; set => _altura = value; }

        public new double CalcularArea()
        {
            double areaBase = Math.PI * Math.Pow(Raio, 2);
            double areaLateral = 2 * Math.PI * Raio * Altura;
            double areaTotal = (2 * areaBase) + areaLateral;
            return areaTotal;
        }

        public new double CalcularVolume() => Math.PI * Math.Pow(Raio, 2) * Altura;

    }
}
