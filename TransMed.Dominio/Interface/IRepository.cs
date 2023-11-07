using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransMed.Dominio.Interface
{
    public interface IRepository<T, TId> :  IAdd<T>, IDelete<TId>, IEditar<T>, IList<T,TId>, ITransaction
    {

    }
}
