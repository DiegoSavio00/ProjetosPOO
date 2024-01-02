using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Curso
    {
        private string _nome;
        private string _horario;
        private Professor _professor;
        private Aluno[] _alunos;

        public string Nome { get => _nome; set => _nome = value; }
        public string Horario { get => _horario; set => _horario = value; }
        public Professor Professor { get => _professor; set => _professor = value; }
        public Aluno[] Alunos { get => _alunos; set => _alunos = value; }

        public string ObterInfo()
        {
            string msg = $"Nome do Curso = {Nome}\n";
            if (Professor is not null)
                msg += Professor.ObterInfo();
            if (Alunos is not null)
            {
                Console.WriteLine("---Alunos---");
                foreach (Aluno aluno in Alunos)
                {
                    if (aluno != null)
                        msg += aluno.ObterInfo();
                }
                msg += "\nMédia da Turma = " + ObterMediaTurma();
            }
            return msg;
        }

        private double ObterMediaTurma()
        {
            double soma = 0;
            foreach (Aluno aluno in Alunos)
            {
                if (aluno != null)
                    soma += aluno.ObterMedia();
            }
            return soma / Alunos.Length;
        }
    }
}
