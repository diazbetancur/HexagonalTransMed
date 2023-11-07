using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransMed.Dominio.Interface
{
    public interface IList<T, TId>
    {
        List<T> listData ();
        List<T> listDataById (TId entity);
    }
}
