namespace AnimalPOO
{
    public class Peixe : Animal
    {
        private string _caracteristicas;

        public string Caracteristicas { get => _caracteristicas; set => _caracteristicas = value; }

        public Peixe() : base()
        {
            Patas = 0;
            Ambiente = "Mar";
            Cor = "Cinzenta";
            Caracteristicas = "Barbatanas e Caudas";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
