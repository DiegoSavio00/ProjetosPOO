namespace AgendaPOO
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Agenda agenda = new(5);
            string nome;
            int idade;
            double altura;

            while (true)
            {
                Console.WriteLine("\n1 Nova Pessoa: ");
                Console.WriteLine("2 Excluir Pessoa: ");
                Console.WriteLine("3 Buscar Pessoa: ");
                Console.WriteLine("4 Imprimir Agenda: ");
                Console.WriteLine("5 Imprimir Pessoa (Índice): ");
                Console.WriteLine("6 Sair: ");
                Console.WriteLine("Sua opção.");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nInforme o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Indorme a idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a altura (use ponto em vez de vírgula): ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        agenda.ArmazenarPessoa(nome, idade, altura);
                        break;

                    case 2:
                        Console.WriteLine("\nInforme o nome a ser removido: ");
                        nome = Console.ReadLine();
                        agenda.RemoverPessoa(nome);
                        break;

                    case 3:
                        Console.WriteLine("\nInforme o nome a ser pesquisado: ");
                        nome = Console.ReadLine();
                        int i = agenda.BuscarPessoa(nome);
                        if (i < 0)
                            Console.WriteLine("\nA pessoa não foi encontrada");
                        else
                            Console.WriteLine("\nA pessoa foi encontrada no índice: " + i);
                        break;

                    case 4:
                        agenda.ImprimirAgenda();
                        break;

                    case 5:
                        Console.WriteLine("\nInforme o índice desejado: ");
                        int index = int.Parse(Console.ReadLine());
                        agenda.ImprimirPessoa(index);
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida\n");
                        break;
                }
            }
        }
    }
}