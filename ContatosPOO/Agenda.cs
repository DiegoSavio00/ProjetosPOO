namespace ContatosPOO
{
    public class Agenda
    {
        private string _proprietario;
        private Pessoa[] _pessoas;
        private int _max;
        private int _cont;

        public Agenda(string proprietario, int max)
        {
            _proprietario = proprietario;
            _max = max;
            _pessoas = new Pessoa[max];
            _cont = 0;
        }

        public void AddPessoa(Pessoa p)
        {
            if (_cont < _max)
            {
                _pessoas[_cont] = p;
                _cont++;
            }
        }

        public Pessoa BuscarPessoa(string nome)
        {
            for (int i = 0; i < _cont; i++)
            {
                if (_pessoas[i].Nome.Equals(nome))
                {
                    return _pessoas[i];
                }
            }
            return null;
        }

        public void AddContato(string nome, Contato c)
        {
            Pessoa p = BuscarPessoa(nome);
            if (p != null)
            {
                p.AddContato(c);
            }
        }

        public void ExibirTodasPessoas()
        {
            for (int i = 0; i < _cont; i++)
            {
                _pessoas[i].Exibir();
            }
        }

        public void ExibirContatosPessoa(string nome)
        {
            Pessoa p = BuscarPessoa(nome);
            if (p != null)
            {
                p.Exibir();
            }
        }

        public void ExibirPessoaComEmail()
        {
            for (int i = 0; i < _cont; i++)
            {
                if (_pessoas[i].PossuiEmail())
                {
                    Console.WriteLine(" - " + _pessoas[i].Nome);
                }
            }
        }

        public void RecuperarPessoaPorEmail(string email)
        {
            for (int i = 0; i < _cont; i++)
            {
                if (_pessoas[i].PossuiEmail())
                {
                    Contato[] vet = _pessoas[i].GetContatos("Email");
                    for (int j = 0; j < vet.Length; j++)
                    {
                        if (vet[j] != null)
                        {
                            Email e = (Email)vet[j];
                            if (e.Emails.Equals(email))
                            {
                                Console.WriteLine(" - " + _pessoas[i].Nome);
                            }
                        }
                    }
                }
            }
        }

        public void RecuperarPessoaPorTelefone(string telefone)
        {
            for (int i = 0; i < _cont; i++)
            {
                if (_pessoas[i].PossuiTelefone())
                {
                    Contato[] vet = _pessoas[i].GetContatos("Telefone");
                    for (int j = 0; j < vet.Length; j++)
                    {

                        if (((Telefone)vet[j]).Telefones.Equals(telefone))
                        {
                            Console.WriteLine(" - " + _pessoas[i].Nome);
                        }
                    }
                }
            }
        }

    }
}
