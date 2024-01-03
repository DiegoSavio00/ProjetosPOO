namespace ContatosPOO
{
    public class Telefone : Contato
    {
        private string telefones;

        public Telefone(string telefone)
        {
            Tipo = "Telefone";
            telefones = telefone;
        }

        public string Telefones { get => telefones; set => telefones = value; }

        public override void Exibir()
        {
            Console.WriteLine("Telefone: " + telefones);
        }
    }
}
