namespace LanchesPOO
{
    public class Lanche : Prato
    {
        private string _pao;
        private string _recheio;
        private string _molho;

        public string Pao { get => _pao; set => _pao = value; }
        public string Recheio { get => _recheio; set => _recheio = value; }
        public string Molho { get => _molho; set => _molho = value; }

        public Lanche()
        {
        }
        public Lanche(
            string pao,
            string recheio,
            string molho,
            string nome,
            double preco,
            string dataValidade,
            double peso) : base(nome, preco, dataValidade, peso)
        {
            Pao = pao;
            Recheio = recheio;
            Molho = molho;
        }

        public Lanche(string pao, string recheio, string molho)
        {
            Pao = pao;
            Recheio = recheio;
            Molho = molho;
        }

        public string Info()
        {
            return $"Pao: {Pao}, Recheio: {Recheio}, Molho: {Molho}";
        }

    }
}
