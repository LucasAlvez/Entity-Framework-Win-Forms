using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Empresa.CadCli.Core.Entidades;

namespace Empresa.CadCli.Core.Data.EF
{
    public class DbInitializer : CreateDatabaseIfNotExists<CadCliDataContext>
    {
        protected override void Seed(CadCliDataContext context)
        {

            var pf = new TipoCliente("Pessoa Fisica");
            var pj = new TipoCliente("Pessoa Juridica");

            context.Clientes.AddRange(new List<Cliente>() { 

            new Cliente("Lucas", pf),
            new Cliente("Microsoft",pj ),
            new Cliente("Gabriel", pf)
            
            });

            context.Funcionarios.Add(new Funcionario("Daniel", 40));
            context.Funcionarios.Add(new Funcionario("Adriano", 38));

            context.SaveChanges();
        }
    }
}
