namespace RelatorioFuncPOO
{
    public abstract class Funcionario
    {
        protected string _nome;
        protected double _salario;

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public double Salario { get => _salario; set => _salario = value; }

        public abstract void CalcularPagamento();
    }
}
