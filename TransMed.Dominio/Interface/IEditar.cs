﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransMed.Dominio.Interface
{
    public interface IEditar<T> : ITransaction
    {
        T Editar (T entity);
    }
}
