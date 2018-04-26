using Empresa.CadCli.Core.Contratos;
using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
namespace Empresa.CadCli.Core.contratos
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        List<Cliente> ObterPorNome(string nome);
    }
}
