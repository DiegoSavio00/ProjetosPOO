using ContaBancariaPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Teste Conta Bancaria ***");
        ContaBancaria contaSimples = new();
        contaSimples.NomeCliente = "Cliente Conta Simples";
        contaSimples.NumConta = "1111";
        contaSimples.Depositar(100);
        RealizarSaque(contaSimples, 50);
        Console.WriteLine(contaSimples);

        Console.WriteLine("*** Teste Conta Poupança ***");
        ContaPoupanca contaPoupanca = new();
        contaPoupanca.NomeCliente = "Cliente Conta Poupança";
        contaPoupanca.NumConta = "22222";
        contaPoupanca.DiaRendimento = 25;
        contaPoupanca.Depositar(100);
        RealizarSaque(contaPoupanca, 50);
        if (contaPoupanca.CalcularNovoSaldo(0.5))
            Console.WriteLine("Rendimento Aplicado, Novo Saldo é de = " + contaPoupanca.Saldo);
        else
            Console.WriteLine("Hoje não é dia de rendimento, novo saldo não calculado.");
        Console.WriteLine(contaPoupanca);

        Console.WriteLine("*** Teste Conta Especial ***");
        ContaEspecial contaEspecial = new();
        contaEspecial.NomeCliente = "Cliente Conta Especial";
        contaEspecial.NumConta = "3333";
        contaEspecial.Limite = 50;
        contaEspecial.Depositar(100);
        RealizarSaque(contaEspecial, 50);
        RealizarSaque(contaEspecial, 70);
        Console.WriteLine(contaEspecial);

    }

    private static void RealizarSaque(ContaBancaria conta, double valor)
    {
        if (conta.Sacar(valor))
            Console.WriteLine("Saque efetuado com sucesso, novo saldo = " + conta.Saldo);
        else
            Console.WriteLine("Saldo insuficiente para saque de " + valor + "; saldo de = " + conta.Saldo);
    }


}