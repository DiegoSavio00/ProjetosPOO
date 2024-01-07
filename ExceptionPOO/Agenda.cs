namespace ExceptionPOO
{
    public class Agenda
    {
        private Contato[] _contatos;


        public Agenda()
        {
            _contatos = new Contato[5];
        }

        public void AdicionarContato(Contato c)
        {
            bool cheia = true;
            for (int i = 0; i < _contatos.Length; i++)
            {
                if (_contatos[i] == null)
                {
                    _contatos[i] = c;
                    cheia = false;
                    break;
                }
            }
            if (cheia)
            {
                throw new AgendaCheiaException();
            }
        }

        public int ConsultarContatosPorNome(string nome)
        {
            for (int i = 0; i < _contatos.Length; i++)
            {
                if (_contatos[i] != null)
                {
                    if (_contatos[i].Nome.Equals(nome))
                        return i;
                }
            }
            throw new ContatoNaoExisteException(nome);
        }

        public override string? ToString()
        {
            string s = "";
            foreach (Contato c in _contatos)
            {
                if (c != null)
                {
                    s += c.ToString() + "\n";
                }
            }
            return s;
        }
    }
}
