using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Entidades
{

    public class TipoCliente:EntidadeBase
    {

        protected TipoCliente()
        {}

        public TipoCliente(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
