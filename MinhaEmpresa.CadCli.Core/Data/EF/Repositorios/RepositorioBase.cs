using Empresa.CadCli.Core.Contratos;
using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.Core.Data.EF.Repositorios
{
    public class RepositorioBase<T>: IRepositorio<T> where T: EntidadeBase
    {
        // CRUD (Create, Read, Update, Delete)

        // readonly só permite que o obj seja instanciado uma única vez e na declaração do ctor
        protected readonly CadCliDataContext ctx = new CadCliDataContext();

        public void Adicionar(T entidade)
        {
            ctx.Set<T>().Add(entidade);
            salvar();
        }

        public void Atualizar(T entidade)
        {
            ctx.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            salvar();
        }

        public void Excluir(T entidade)
        {
            ctx.Set<T>().Remove(entidade);
            salvar();
        }

        public T ObterPorId(int id)
        {
            return ctx.Set<T>().Find(id);
        }

        public List<T> ObterTodos()
        {
            return ctx.Set<T>().ToList();
        }

        private void salvar()
        {
            ctx.SaveChanges();
        }
    }
}
