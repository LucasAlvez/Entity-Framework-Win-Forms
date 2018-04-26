using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Entidades
{
    // internal class Cliente
    public class Cliente:EntidadeBase
    {

        protected Cliente()
        {}


        public Cliente(string nome, TipoCliente tipo)
        {
            this.nome = nome;
            this.TipoCliente = tipo;
           
        }

        public Cliente(string nome, int tipo)
        {
            this.nome = nome;
            this.tipoClienteId = tipo;

        }

        
        public string nome { get; set; }
        public int tipoClienteId { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }


    }
}
