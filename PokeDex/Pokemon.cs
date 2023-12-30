namespace PokeDex
{
    public class Pokemon
    {
        private string _nome;
        private string _descricao;

        public Pokemon()
        {
        }

        public Pokemon(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get => _nome; set => _nome = value.ToUpper(); }
        public string Descricao { get => _descricao; set => _descricao = value; }

        public string ExibirDados()
        {
            return $"Nome do Pokemon: {Nome}\n Descrição do Pokemon: {Descricao}";
        }
    }
}
