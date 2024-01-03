namespace ContaBancariaPOO
{
    public class ContaBancaria
    {
        private string _nomeCliente;
        private string numConta;
        private double _saldo;

        public ContaBancaria()
        {
        }

        public string NomeCliente { get => _nomeCliente; set => _nomeCliente = value; }
        public string NumConta { get => numConta; set => numConta = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if ((Saldo - valor) >= 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

    }
}
