namespace AnimalPOO
{
    public class Mamifero : Animal
    {
        private string _alimento;

        public Mamifero() : base()
        {
            Cor = "Castanho";
            Ambiente = "Terra";
            Alimento = "Mel";
        }

        public string Alimento { get => _alimento; set => _alimento = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
