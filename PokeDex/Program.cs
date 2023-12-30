using PokeDex;

internal class Program
{
    private static void Main(string[] args)
    {
        Pokedex pokedex = new();
        int resp = 1;
        while (resp != 0)
        {
            resp = Menu();
            if (resp is 1)
                pokedex.ListarPokemons();
            Console.ReadKey();
        }
        Console.ReadKey();
        Console.Clear();
    }

    static int Menu()
    {
        Console.WriteLine("Pokedex --- Agenda Pokemon");
        Console.WriteLine("0 - Sair da Pokedex");
        Console.WriteLine("1 - Listar todos os Pokemons");
        Console.Write("Opção: ");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
}