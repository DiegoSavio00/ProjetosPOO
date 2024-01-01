namespace FigurasGeometricasPOO
{
    public class Circulo : Figura2D
    {
        private double _raio;

        public double Raio { get => _raio; set => _raio = value; }

        public new double CalcularArea => (Raio * Raio) * Math.PI;
    }
}
