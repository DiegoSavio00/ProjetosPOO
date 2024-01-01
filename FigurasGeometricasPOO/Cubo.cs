namespace FigurasGeometricasPOO
{
    public class Cubo : Figura3D
    {
        private int _lado;

        public int Lado { get => _lado; set => _lado = value; }

        public new double CalcularArea()
        {
            return 6 * (Lado * Lado);
        }

        public new double CalcularVolume()
        {
            return Math.Pow(Lado, 3);
        }
    }
}
