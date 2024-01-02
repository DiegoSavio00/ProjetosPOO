namespace AnimalPOO
{
    public class Animal
    {
        private string _nome;
        private int _comprimento;
        private int _patas;
        private string _cor;
        private double _velocidade;
        private string _ambiente;

        public Animal()
        {
            Patas = 4;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Comprimento { get => _comprimento; set => _comprimento = value; }
        public int Patas { get => _patas; set => _patas = value; }
        public string Cor { get => _cor; set => _cor = value; }
        public double Velocidade { get => _velocidade; set => _velocidade = value; }
        public string Ambiente { get => _ambiente; set => _ambiente = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
