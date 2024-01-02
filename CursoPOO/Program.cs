// Exercicio!!
// Escreva uma classe para representar um Curso, que tem nome e horário.
// Cada curso tem um Professor que possui nome, departamento e email.
// Cada Curso também pode ter vários alunos(tipo Aluno). Cada Aluno tem...
// nome, matricula e 4 notas. Escreva um programa teste que crie um Curso
// com 5 alunos, e que peça para o usuário entrar com as 4 notas de cada...
// aluno. Ao final, imprima a média de cada aluno, se o mesmo está aprovado
// (media maior ou igual a 7), e qual é a média da turma.

using CursoPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com o nome do curso: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Entre com horário do curso: ");
        string horario = Console.ReadLine();
        Console.WriteLine("Entre com o nome do professor: ");
        string nomeProfessor = Console.ReadLine();
        Console.WriteLine("Entre com departamento do professor: ");
        string depProfessor = Console.ReadLine();
        Console.WriteLine("Entre com o email do professor: ");
        string email = Console.ReadLine();

        Curso curso = new();
        curso.Nome = nome;
        curso.Horario = horario;

        Professor professor = new();
        professor.Nome = nome;
        professor.Departamento = depProfessor;
        professor.Email = email;

        // Curso recebendo professor.
        curso.Professor = professor;

        Console.WriteLine("---Alunos---");

        Aluno[] alunos = new Aluno[5];
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("Entre com o nome do aluno: " + (i + 1));
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("Entre com a matricula do aluno: " + (i + 1));
            string matAluno = Console.ReadLine();
            double[] notas = new double[4];
            for (int j = 0; j < notas.Length; j++)
            {
                Console.WriteLine("Entre com a nota: " + (j + 1));
                notas[j] = Convert.ToDouble(Console.ReadLine());
            }
            Aluno aluno = new();
            aluno.Nome = nomeAluno;
            aluno.Matricula = matAluno;
            aluno.Notas = notas;
            alunos[i] = aluno;
        }

        // Curso recebendo Aluno
        curso.Alunos = alunos;
        Console.WriteLine(curso.ObterInfo());

    }
}