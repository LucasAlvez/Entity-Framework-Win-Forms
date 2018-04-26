using Empresa.CadCli.Core.contratos;
using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Data.EF.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public List<Cliente> ObterPorNome(string nome)
        {
            return ctx.Clientes.Where(c => c.nome.Contains(nome)).ToList();
        }
    }
}
