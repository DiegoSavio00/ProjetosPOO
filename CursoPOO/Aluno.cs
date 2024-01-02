using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Aluno
    {
        private string _nome;
        private string _matricula;
        private double[] _notas;

        public string Nome { get => _nome; set => _nome = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
        public double[] Notas { get => _notas; set => _notas = value; }

        public string ObterInfo()
        {
            string msg = $"Nome do Aluno = {Nome}" +
                $"| Matricula = {Matricula} | Notas: {Notas}";
            double soma = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                soma += Notas[i];
                msg += Notas + " ";
            }
            double media = soma / 4;
            msg += $"\nMédia = {media} - ";
            if (media >= 7)
                msg += "Aprovado!";
            else
                msg += "Reprovado!";
            return msg;
        }

        public double ObterMedia()
        {
            double soma = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                soma += Notas[i];
            }
            return soma / 4;
        }

    }
}
