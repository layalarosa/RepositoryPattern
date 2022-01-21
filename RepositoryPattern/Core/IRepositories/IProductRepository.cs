using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepositories
{
    interface IProductRepository : IGenericRepository<Product>
    {
        public Task<bool> Add(User entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<User>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
