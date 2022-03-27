using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepositories
{
    interface IProductRepository : IGenericRepository<Product>
    {
        public Task<bool> Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<Product>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
