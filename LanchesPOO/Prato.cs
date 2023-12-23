namespace LanchesPOO
{
    public class Prato
    {
        private string _nome;
        private double _preco;
        private string _dataValidade;
        private double _peso;

        public Prato()
        {
        }

        public Prato(string nome, double preco, string dataValidade, double peso)
        {
            Nome = nome;
            Preco = preco;
            DataValidade = dataValidade;
            Peso = peso;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public string DataValidade { get => _dataValidade; set => _dataValidade = value; }
        public double Peso { get => _peso; set => _peso = value; }

        public string Info()
        {
            return $"Nome: {Nome}, Preço: {Preco}, DataValidade: {DataValidade}, Peso: {Peso}";
        }

    }
}
