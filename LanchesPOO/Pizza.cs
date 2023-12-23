namespace LanchesPOO
{
    public class Pizza : Prato
    {
        private string _molho;
        private string _recheio;
        private string _borda;

        public Pizza(
            string molho,
            string recheio,
            string borda)
        {
            Molho = molho;
            Recheio = recheio;
            Borda = borda;
        }

        public Pizza(
            string molho,
            string recheio,
            string borda,
            string nome,
            double preco,
            string dataValidade,
            double peso) : base(nome, preco, dataValidade, peso)
        {
            Molho = molho;
            Recheio = recheio;
            Borda = borda;
        }

        public string Molho { get => _molho; set => _molho = value; }
        public string Recheio { get => _recheio; set => _recheio = value; }
        public string Borda { get => _borda; set => _borda = value; }

        public string Info()
        {
            return $"Molho: {Molho}, Recheio: {Recheio}, Borda: {Borda}";
        }
    }
}
