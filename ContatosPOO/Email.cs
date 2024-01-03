namespace ContatosPOO
{
    public class Email : Contato
    {
        private string emails;

        public Email(string email)
        {
            Tipo = "Email";
            Emails = email;
        }

        public string Emails { get => emails; set => emails = value; }

        public override void Exibir()
        {
            Console.WriteLine("Email: " + Emails);
        }
    }
}
