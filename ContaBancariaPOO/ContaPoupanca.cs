using System.Globalization;

namespace ContaBancariaPOO
{
    public class ContaPoupanca : ContaBancaria
    {
        private int _diaRendimento;

        public ContaPoupanca()
        {
        }

        public int DiaRendimento { get => _diaRendimento; set => _diaRendimento = value; }

        public bool CalcularNovoSaldo(double taxaRendimento)
        {
            DateTime hoje = DateTime.Now;
            if (DiaRendimento == hoje.Day)
            {
                Saldo += (Saldo * taxaRendimento);
                return true;
            }
            return false;
        }

    }
}
