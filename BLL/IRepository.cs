using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IRepository<T>  where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> expression);
        bool Guardar(T entity);
        bool Eliminar(int id);
        bool Modificar(T entity);
        T Buscar(int id);
    }
}
