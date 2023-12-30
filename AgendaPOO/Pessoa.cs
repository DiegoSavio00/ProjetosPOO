namespace AgendaPOO
{
    public class Pessoa
    {
        private string _nome;
        private double _altura;
        private int _idade;

        public Pessoa()
        {
        }

        public Pessoa(string nome, double altura, int idade)
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public double Altura { get => _altura; set => _altura = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}\n Idade: {Idade}\n Altura: {Altura}");
        }

    }
}
