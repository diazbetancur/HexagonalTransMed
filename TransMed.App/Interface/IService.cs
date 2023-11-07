using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransMed.Dominio.Interface;

namespace TransMed.App.Interface
{
    public interface IService<T, TId> : IAdd<T> , IEditar<T>, IDelete<T>, IList<T, TId>
    {
    }
}
