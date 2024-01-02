using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Professor
    {
        private string _nome;
        private string _departamento;
        private string _email;

        public string Nome { get => _nome; set => _nome = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
        public string Email { get => _email; set => _email = value; }

        public string ObterInfo() => $"Professor = {Nome}";

    }
}
