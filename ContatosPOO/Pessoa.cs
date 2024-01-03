namespace ContatosPOO
{
    public class Pessoa
    {
        private string nome;
        protected Contato[] _contatos;
        protected int _max;
        protected int _cont;

        public string Nome { get => nome; set => nome = value; }

        public Pessoa(string nome, int max)
        {
            Nome = nome;
            _max = max;
            _contatos = new Contato[max];
            _cont = 0;
        }

        public void AddContato(Contato c)
        {
            if (_cont < _max)
            {
                _contatos[_cont] = c;
                _cont++;
            }
        }

        public Contato[] GetContatos()
        {
            return _contatos;
        }

        public Contato[] GetContatos(string tipo)
        {
            int contC = 0;
            for (int i = 0; i < _cont; i++)
            {
                if (_contatos[i].Tipo.Equals(tipo))
                {
                    contC++;
                }
            }
            if (contC > 0)
            {
                Contato[] vet = new Contato[contC];
                int contNovo = 0;
                for (int i = 0; i < _cont; i++)
                {
                    if (_contatos[i].Tipo.Equals(tipo))
                    {
                        vet[contNovo] = _contatos[i];
                        contNovo++;
                    }
                }
                return vet;
            }
            return null;
        }

        public bool PossuiEmail()
        {
            int contC = 0;
            for (int i = 0; i < _cont; i++)
            {
                if (_contatos[i].Tipo.Equals("Email"))
                    return true;
            }
            return false;
        }

        public bool PossuiTelefone()
        {
            int contC = 0;
            for (int i = 0; i < _cont; i++)
            {
                if (_contatos[i].Tipo.Equals("Telefone"))
                    return true;
            }
            return false;
        }

        public void Exibir()
        {
            Console.WriteLine("Nome: " + Nome);
            for (int i = 0; i < _cont; i++)
            {
                _contatos[i].Exibir();
            }
        }

    }
}
