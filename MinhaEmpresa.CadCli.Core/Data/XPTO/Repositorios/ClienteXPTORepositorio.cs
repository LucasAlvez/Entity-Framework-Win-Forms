using Empresa.CadCli.Core.contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.CadCli.Core.Data.XPTO.Repositorios;
using Empresa.CadCli.Core.Entidades;

namespace Empresa.CadCli.Core.Data.XPTO.Repositorios
{
    public class ClienteXPTORepositorio : IClienteRepositorio
    {

        public void Adicionar(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            return new List<Cliente>()
            {
                new Cliente("XPTO", new TipoCliente("PF"))   
            };
        }

        public List<Cliente> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
