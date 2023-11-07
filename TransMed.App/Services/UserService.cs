using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransMed.App.Interface;
using TransMed.Dominio.Entity;
using TransMed.Dominio.Interface;

namespace TransMed.App.Services
{
    public class UserService : IService<User, Guid>
    {
        private readonly IRepository<User, Guid> _repository;

        public UserService(IRepository<User, Guid> repository)
        {
            _repository = repository;
        }
        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(Guid entityId)
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
