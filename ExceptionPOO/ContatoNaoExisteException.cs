namespace ExceptionPOO
{
    public class ContatoNaoExisteException : Exception
    {
        public string NomeContato { get; set; }

        public ContatoNaoExisteException(string nomeContato)
        {
            NomeContato = nomeContato;
        }

        public override string Message => "Contato " + NomeContato + " não existe na agenda!!";
    }
}
