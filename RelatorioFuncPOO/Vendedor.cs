namespace RelatorioFuncPOO
{
    public class Vendedor : Funcionario
    {
        private double _totalVendas;

        public Vendedor(string nome, double salario, double totalVendas) : base(nome, salario)
        {
            TotalVendas = totalVendas;
        }

        public double TotalVendas { get => _totalVendas; set => _totalVendas = value; }

        public override void CalcularPagamento()
        {
            Salario += (TotalVendas * 0.05);
        }
    }
}
