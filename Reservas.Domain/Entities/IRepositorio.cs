using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Entities
{
   public interface IRepositorio<T> where T : class
    {
        IQueryable<T> ListarTodasPessoas();
        IQueryable<T> Buscar(Func<T, bool> where, params Expression<Func<T ,object>>[] includeProperties);
        T Adiciona(T entidade);
        T Alterar(T entidade);
        void Excluir(T codigo);

        }
}
