using ExceptionPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Agenda agenda = new();
        int opcao = 1;
        while (opcao != 3)
        {
            opcao = MenuOpcoes();
            if (opcao == 1)
                ConsultarContato(agenda);
            else if (opcao == 2)
                AdicionarContato(agenda);
            else if (opcao == 3)
                Environment.Exit(0);
        }
    }

    static int MenuOpcoes()
    {
        int opcao = 3;
        bool entradaValida = false;
        do
        {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1: Consultar Contato: ");
            Console.WriteLine("2: Adicionar Contato: ");
            Console.WriteLine("3: Sair ");
            try
            {
                string entrada = Console.ReadLine();
                opcao = Convert.ToInt32(entrada);
                if (opcao == 1 || opcao == 2 || opcao == 3)
                {
                    entradaValida = true;
                }
                else
                {
                    throw new Exception("Entrada Inválida");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Entrada inválida, digite novamente!");
            }
        } while (!entradaValida);
        return opcao;
    }

    static void AdicionarContato(Agenda agenda)
    {
        Console.WriteLine("Criando um contato, entre com as informações");
        string nome = LerInformacao("Entre com o nome do contato");
        string telefone = LerInformacao("Entre com o telefone do contato");
        string email = LerInformacao("Entre com o email do contato");

        Contato contato = new();
        contato.Nome = nome;
        contato.Telefone = telefone;
        contato.Email = email;

        Console.WriteLine("Contato a ser criado: ");
        Console.WriteLine(contato);

        try
        {
            agenda.AdicionarContato(contato);
        }
        catch (AgendaCheiaException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Contatos da agenda");
            Console.WriteLine(agenda);
        }
    }

    static void ConsultarContato(Agenda agenda)
    {
        string nomeCompleto = LerInformacao("Entre com o nome do contato a ser pesquisado.");
        try
        {
            if (agenda.ConsultarContatosPorNome(nomeCompleto) >= 0)
            {
                Console.WriteLine("Contato existe");
            }
        }
        catch (ContatoNaoExisteException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static string LerInformacao(string msg)
    {
        Console.WriteLine(msg);
        string entrada = Console.ReadLine();
        return entrada;
    }

}