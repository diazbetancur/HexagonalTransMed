using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransMed.Dominio.Interface
{
    public interface IAdd<T> : ITransaction
    {
        T Add (T entity);
    }
}
