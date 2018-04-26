using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Data.EF
{
    public class CadCliDataContext: DbContext
    {
        public CadCliDataContext():base("CadCliConn")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}
