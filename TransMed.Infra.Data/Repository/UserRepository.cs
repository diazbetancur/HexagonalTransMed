using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransMed.Dominio.Entity;
using TransMed.Dominio.Interface;
using TransMed.Infra.Data.Context;

namespace TransMed.Infra.Data.Repository
{
    public class UserRepository : IRepository<User, Guid>
    {
        private UserContext db;

        public UserRepository( UserContext userContext)
        {
            db = userContext; // Para poder ejecutar cambios en el repositorio
        }
        public User Add(User entity)
        {
            entity.Id = Guid.NewGuid();
            db.Users.Add(entity);
            return entity;
        }

        public Guid Delete(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public User Editar(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> listData()
        {
            throw new NotImplementedException();
        }

        public List<User> listDataById(Guid entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
