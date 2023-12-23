namespace LanchesPOO
{
    public class Pedido
    {
        private string _nomeCliente;
        private double _taxaDeServico;
        private List<Prato> _itensConsumidos;

        public Pedido(string nomeCliente, double taxaDeServico, List<Prato> itensConsumidos)
        {
            NomeCliente = nomeCliente;
            TaxaDeServico = taxaDeServico;
            ItensConsumidos = itensConsumidos;
        }

        public Pedido()
        {
            _itensConsumidos = new List<Prato>();
        }

        public string NomeCliente { get => _nomeCliente; set => _nomeCliente = value; }
        public double TaxaDeServico { get => _taxaDeServico; set => _taxaDeServico = value; }
        public List<Prato> ItensConsumidos { get => _itensConsumidos; set => _itensConsumidos = value; }

        public double CalcularTaxaDeServico()
        {
            double somaItens = 0.0;
            foreach (var prato in ItensConsumidos)
            {
                somaItens += prato.Preco;
            }
            double taxa = somaItens * 0.1;
            return taxa;
        }

        public double CalcularTroco()
        {
            double valorRecebido;
            valorRecebido = Convert.ToDouble(Console.ReadLine());
            double somaItens = 0.0;
            foreach (var prato in ItensConsumidos)
            {
                somaItens += prato.Preco;
            }
            double troco = (valorRecebido - somaItens);
            return troco;
        }

        public void ImprimirNota()
        {
            Console.WriteLine("===Nota Fiscal===");
            Console.WriteLine("Itens Consumidos");
            double valorFinal = 0.0;
            foreach (var prato in ItensConsumidos)
            {
                Console.WriteLine(prato);
                valorFinal += prato.Preco;
            }
            Console.WriteLine($"Valor Final a pagar: {valorFinal}");
            Console.WriteLine($"A taxa de serviço é: {CalcularTaxaDeServico()}");
            Console.WriteLine($"O troco é: {CalcularTroco()}");
            Console.WriteLine("   FIM!   ");
        }

    }
}
