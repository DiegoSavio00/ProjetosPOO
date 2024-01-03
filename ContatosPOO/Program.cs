// Os diagramas abaixo representam classes de parte de um programa de uma agenda
// que vai armazenar pessoas. Uma pessoa pode ter vários contatos, ou seja,
// pode ter vários números de telefone ou email.

// abstract Contato 
//    string tipo/tipo de contato
//    Contato(string tipo)
//    abstract void exibir()

// Email                            Telefone
//    string email                      string telefone
//    Email(string email)               Telefone(string telefone)
//    void exibir()                     void exibir()

// Pessoa

using ContatosPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p = new("Pessoa 1", 50);
        p.AddContato(new Email("pessoa1@hotmail.com"));
        p.AddContato(new Email("pessoa1@gmail.com"));
        p.AddContato(new Telefone("32456125"));
        p.AddContato(new Telefone("994754564"));
        p.Exibir();
        Console.WriteLine("Possui Email: " + p.PossuiEmail());
        Console.WriteLine("Possui Telefone: " + p.PossuiTelefone());

        Pessoa p1 = new("Pessoa sem email", 50);
        p1.AddContato(new Telefone("12345678"));
        p1.AddContato(new Telefone("19999"));

        Pessoa p2 = new("Pessoa sem telefone", 50);
        p2.AddContato(new Email("asdfsa@hotmail.com"));

        Pessoa p3 = new("Pessoa sem contato", 50);

        Agenda ag = new("Diego", 100);
        ag.AddPessoa(p);
        ag.AddPessoa(p1);
        ag.AddPessoa(p2);
        ag.AddPessoa(p3);
        ag.ExibirTodasPessoas();
        ag.ExibirContatosPessoa("Pessoa sem Telefone");
        ag.ExibirPessoaComEmail();
        ag.RecuperarPessoaPorEmail("asdfsa@hotmail.com");
        ag.RecuperarPessoaPorTelefone("19999");
        ag.ExibirTodasPessoas();
    }
}