using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Entidades
{
    public class Funcionario:EntidadeBase
    {
        protected Funcionario()
        {}

        public Funcionario(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string nome { get; set; }
        public int idade { get; set; }

    }
}
