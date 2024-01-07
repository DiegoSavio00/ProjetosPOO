namespace ExceptionPOO
{
    public class AgendaCheiaException : Exception
    {
        public override string Message => "Agenda já está cheia!!";
    }
}
