namespace ContaBancariaPOO
{
    public class ContaEspecial : ContaBancaria
    {
        private double _limite;

        public double Limite { get => _limite; set => _limite = value; }

        public bool Sacar(double valor)
        {
            double saldoComLimite = Saldo + Limite;
            if ((saldoComLimite - valor) >= 0)
            {
                Saldo += Saldo - valor;
                return true;
            }
            return false;
        }

    }
}
