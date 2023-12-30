namespace DigiBankPOO
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        double ConsultarSaldo();
        string BuscarCodigoDoBanco();
        string BuscarNumeroDaAgencia();
        string BuscarNumeroDaConta();
        List<Extrato> Extatos();
    }
}
