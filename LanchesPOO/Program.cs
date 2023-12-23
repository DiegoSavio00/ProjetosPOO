
using LanchesPOO;

internal class Program
{
    static List<Prato> pratosDisponiveis = new();
    static List<Pedido> pedidos = new();
    private static void Main(string[] args)
    {
        Dados();
        while (true)
        {
            Console.WriteLine("---Bem Vindos ao Quase Três Lanches---");
            Console.WriteLine("1) Fazer Pedido\n 2) Sair ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    FazerPedido();
                    break;
                case 2:
                    return;
            }
        }
    }

    static void FazerPedido()
    {
        Pedido pedido = new();
        Console.WriteLine("Nome do Cliente: ");
        pedido.NomeCliente = Console.ReadLine();
        int op = -1;
        while (true)
        {
            for (int i = 0; i < pratosDisponiveis.Count; i++)
                Console.WriteLine($"{i} ( {pratosDisponiveis[i].Nome}");
            Console.WriteLine("Digite 0 para encerrar o pedido");
            op = Convert.ToInt32(Console.ReadLine());
            if (op is not 0)
            {
                List<Prato> temp = new();
                temp = pedido.ItensConsumidos;
                Console.WriteLine(temp);
                temp.Add(pratosDisponiveis[op]);
                pedido.ItensConsumidos = temp;
            }
            else
            {
                break;
            }
            pedido.ImprimirNota();
        }
    }

    static void Dados()
    {
        Pizza p1 = new("Bolonhesa", "peperoni", "catupiry", "Pizza de peperoni", 40.0, "22/11/2020", 40);
        Pizza p2 = new("3 Queijos", "Gorgonzola", "calabresa", "Pizza de 3 queijos", 40.0, "10/2/2020", 40);
        Lanche l1 = new("Brioche", "calabresa", "Catshup mostarda", "Calabria", 13, "22/10/2020", 300);
        Lanche l2 = new("Francês", "Ovos e bacon", "Catupiry", "Francaise", 33, "13/11/202", 400);
        pratosDisponiveis.Add(p1);
        pratosDisponiveis.Add(p2);
        pratosDisponiveis.Add(l1);
        pratosDisponiveis.Add(l2);
    }
}