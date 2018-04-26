using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Contratos
{
    public interface IRepositorio<T> where T:EntidadeBase
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
        T ObterPorId(int id);
        List<T> ObterTodos();
    }
}
