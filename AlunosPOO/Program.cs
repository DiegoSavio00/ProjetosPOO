using AlunosPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "## Média Geral dos Alunos ##";
        int nAlunos = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Aluno[] alunos = new Aluno[nAlunos];
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.Clear();
            Console.WriteLine("Aluno #" + (i + 1) + "Nome...: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Aluno #" + (i + 1) + " Provas...: ");
            int provas = int.Parse(Console.ReadLine());

            alunos[i] = new Aluno(nome, provas);
            Console.WriteLine("Insira as notas do aluno: " + nome);
            alunos[i].InserirNotas();
        }

        Console.Clear();

        double mediaGeral = 0;
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine("Aluno: " + aluno.Nome);
            Console.WriteLine("Media: " + aluno.Media);
            Console.WriteLine();
            mediaGeral += aluno.Media;
        }

        double resultadoFinal = mediaGeral / alunos.Length;
        Console.WriteLine("Média Geral dos alunos: " + resultadoFinal);
    }
}