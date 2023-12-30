namespace AgendaPOO
{
    public class Agenda
    {
        private Pessoa[] _pessoas;

        public Agenda(int quantiadade)
        {
            Pessoas = new Pessoa[quantiadade];
        }

        public Pessoa[] Pessoas { get => _pessoas; set => _pessoas = value; }

        public void ArmazenarPessoa(string nome, int idade, double altura)
        {
            bool cadastro = false;
            for (int i = 0; i < Pessoas.Length; i++)
            {
                if (Pessoas[i] is null)
                {
                    var p = new Pessoa(nome, altura, idade);
                    Pessoas[i] = p;
                    cadastro = true;
                    break;
                }
            }
            if (cadastro)
                Console.WriteLine("\nCadastro efetuado com sucesso!!");
            else
                Console.WriteLine("\nNão foi possível cadastrar, está cheio!!");
        }

        public void RemoverPessoa(string nome)
        {
            bool excluido = false;
            for (int i = 0; i < Pessoas.Length; i++)
            {
                if (Pessoas[i] is not null)
                {
                    if (Pessoas[i].Nome.Equals(nome))
                    {
                        Pessoas[i] = null;
                        excluido = true;
                        break;
                    }
                }
            }
            if (excluido)
                Console.WriteLine("\nPessoa removida com sucesso!!");
            else
                Console.WriteLine("\nNão foi possível remover!!");
        }

        public int BuscarPessoa(string nome)
        {
            int resultado = -1;
            for (int i = 0; i < Pessoas.Length; i++)
            {
                if (Pessoas[i] is not null)
                {
                    if (Pessoas[i].Nome.Equals(nome))
                    {
                        resultado = i;
                        break;
                    }
                }
            }
            return resultado;
        }

        public void ImprimirAgenda()
        {
            for (int i = 0; i < Pessoas.Length; i++)
            {
                if (Pessoas[i] is not null)
                {
                    var p = Pessoas[i];
                    Console.WriteLine("\nNome: " + p.Nome);
                    Console.WriteLine("\nIdade: " + p.Idade);
                    Console.WriteLine("\nAltura: " + p.Altura);
                }
            }
        }

        public void ImprimirPessoa(int i)
        {
            if (i < 0 || (i > (Pessoas.Length - 1)))
            {
                Console.WriteLine("\nÍndice inválido");
            }
            else
            {
                var p = Pessoas[i];
                if (p is null)
                    Console.WriteLine("\nNão existe pessoa nesse índice ainda");
                else
                {
                    Console.WriteLine("\nNome: " + p.Nome);
                    Console.WriteLine("\nIdade: " + p.Idade);
                    Console.WriteLine("\nAltura: " + p.Altura);
                }
            }

        }

    }
}
