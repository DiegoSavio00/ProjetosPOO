namespace DigiBankPOO
{
    public static class Layout
    {
        private static List<Pessoas> pessoas = new();
        private static int opcao = 0;

        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("                                 ");
            Console.WriteLine("    Digite a Opção Desejada :    ");
            Console.WriteLine("    1 - Criar Conta              ");
            Console.WriteLine("    2 - Entrar com CPF e Senha   ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Opção 1");
                    TelaCriarConta();
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        private static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("                                 ");
            Console.WriteLine("    Digite seu nome:             ");
            string nome = Console.ReadLine();
            Console.WriteLine("    Digite seu CPF:              ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    Digite sua Senha:            ");
            string senha = Console.ReadLine();
            ContaCorrente contaCorrente = new();
            Pessoas pessoa = new();
            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente;
            pessoas.Add(pessoa);
            Console.Clear();
            Console.WriteLine("  Conta cadastrada com sucesso   ");
            Thread.Sleep(1000);
            TelaContaLogada(pessoa);
        }

        private static void TelaLogin()
        {
            Console.Clear();
            Console.WriteLine("    Digite seu CPF:              ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    Digite sua Senha:            ");
            string senha = Console.ReadLine();
            Pessoas pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);
            if (pessoa != null)
            {
                TelaBoasVindas(pessoa);
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("   Pessoa não cadastrada     ");
            }
        }

        private static void TelaBoasVindas(Pessoas pessoa)
        {
            string msgTelaBemVindo = $"{pessoa.Nome} Banco: {pessoa.Conta.BuscarCodigoDoBanco()} " +
                $"| Agencia: {pessoa.Conta.BuscarNumeroDaAgencia()} " +
                $"| Conta: {pessoa.Conta.BuscarNumeroDaConta()}";
            Console.WriteLine("");
            Console.WriteLine($"    Seja bem vindo, {msgTelaBemVindo}");
        }

        private static void TelaContaLogada(Pessoas pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("    Digite a Opção desejada:       ");
            Console.WriteLine("    1 - Realizar Deposito          ");
            Console.WriteLine("    2 - Realizar Saque             ");
            Console.WriteLine("    3 - Consultar Saldo            ");
            Console.WriteLine("    4 - Extrato                    ");
            Console.WriteLine("    5 - Sair                       ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3:
                    TelaSaldo(pessoa);
                    break;
                case 4:
                    TelaExtrato(pessoa);
                    break;
                case 5:
                    TelaPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("    Opção Inválida!                ");
                    Console.WriteLine("    =========================      ");
                    break;
            }
        }

        private static void TelaDeposito(Pessoas pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("    Digite o valor do Deposito       ");
            double valor = double.Parse(Console.ReadLine());
            pessoa.Conta.Depositar(valor);
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                     ");
            Console.WriteLine("                                     ");
            Console.WriteLine("  Deposito Realizado com Sucesso     ");
            Console.WriteLine("                                     ");
            Console.WriteLine("                                     ");
            OpcaoVoltarLogado(pessoa);
        }

        private static void TelaSaque(Pessoas pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("    Digite o valor do Saque          ");
            double valor = double.Parse(Console.ReadLine());
            bool OkSaque = pessoa.Conta.Sacar(valor);
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                     ");
            Console.WriteLine("                                     ");
            if (OkSaque)
            {
                Console.WriteLine("  Saque Realizado com Sucesso        ");
            }
            else
            {
                Console.WriteLine("  Saldo Insuficiente!                ");
            }
            Console.WriteLine("                                     ");
            Console.WriteLine("                                     ");
            OpcaoVoltarLogado(pessoa);
        }


        private static void TelaExtrato(Pessoas pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            if (pessoa.Conta.Extatos().Any())
            {
                double total = pessoa.Conta.Extatos().Sum(x => x.Valor);
                foreach (Extrato extrato in pessoa.Conta.Extatos())
                {
                    Console.WriteLine("                                              ");
                    Console.WriteLine($"  Data: {extrato.Data.ToString("dd/MM/yyyy HH:mm:ss")}  ");
                    Console.WriteLine($"  Tipo de Movimentação {extrato.Descricao}   ");
                    Console.WriteLine($"  Valor: {extrato.Descricao}                 ");
                    Console.WriteLine("   ================================           ");
                }
                Console.WriteLine("                                      ");
                Console.WriteLine("                                      ");
                Console.WriteLine($"    SUB TOTAL: {total}               ");
                Console.WriteLine("    ===========================       ");
            }
            else
            {
                Console.WriteLine("    Não há extrato a ser exibido!     ");
                Console.WriteLine("    ===========================       ");
            }
            OpcaoVoltarLogado(pessoa);
        }

        private static void TelaSaldo(Pessoas pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine($"  Seu Saldo é: {pessoa.Conta.ConsultarSaldo()}  ");
            Console.WriteLine("                                                ");
            OpcaoVoltarLogado(pessoa);
        }

        private static void OpcaoVoltarLogado(Pessoas pessoa)
        {
            Console.WriteLine("    Entre com uma opção abaixo?       ");
            Console.WriteLine("    1 - Voltar para minha conta       ");
            Console.WriteLine("    2 - Sair                          ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                TelaContaLogada(pessoa);
            }
            else
            {
                TelaPrincipal();
            }
        }

        private static void OpcaoVoltarDeslogado(Pessoas pessoa)
        {
            Console.WriteLine("    Entre com uma opção abaixo?       ");
            Console.WriteLine("    1 - Voltar para o menu principal  ");
            Console.WriteLine("    2 - Sair                          ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                TelaPrincipal();
            }
            else
            {
                Console.WriteLine("...      Opção Inválida!              ");
            }
        }

    }
}
