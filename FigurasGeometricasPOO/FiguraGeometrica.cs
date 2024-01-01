namespace FigurasGeometricasPOO
{
    public abstract class FiguraGeometrica
    {
        private string _nome;
        private string _cor;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cor { get => _cor; set => _cor = value; }
    }
}
