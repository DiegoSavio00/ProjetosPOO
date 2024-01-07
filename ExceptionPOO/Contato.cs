namespace ExceptionPOO
{
    public class Contato
    {
        private static int contador = 0;

        private int _id;
        private string _nome;
        private string _telefone;
        private string _email;

        public Contato()
        {
            contador++;
            _id = contador;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email { get => _email; set => _email = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
