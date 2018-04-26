using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Entidades
{
    public abstract class EntidadeBase
    {

        public EntidadeBase()
        {
            dataCadastro = DateTime.Now;
        }

        public int id { get; set; }
        public DateTime dataCadastro { get; set; }

    }
}
