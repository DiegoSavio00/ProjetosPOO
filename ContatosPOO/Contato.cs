namespace ContatosPOO
{
    public abstract class Contato
    {
        protected string _tipo;
        public Contato()
        {
            Tipo = "Contato";
        }

        public string Tipo { get => _tipo; set => _tipo = value; }

        public abstract void Exibir();
    }
}
