namespace PokeDex
{
    public class Pokedex
    {
        private List<Pokemon> _pokemons;

        public List<Pokemon> Pokemons { get => _pokemons; set => _pokemons = value; }

        public Pokedex()
        {
            IniciarLista();
        }

        private void IniciarLista()
        {
            _pokemons = new List<Pokemon>();
            var p = new Pokemon("Pikachu.", "Tipo Eletrico.");
            Pokemons.Add(p);
            // Mais pokemons!!
            p = new Pokemon("Charmander", "Tipo Fogo");
            Pokemons.Add(p);
            p = new Pokemon("Mew", "Psiquico.");
            Pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Pokemons[i].ExibirDados();
            }
        }

    }
}
