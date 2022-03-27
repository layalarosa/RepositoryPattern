using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepositories
{
    interface IAuthorRepository : IGenericRepository<Author>
    {
        public Task<bool> Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<Author>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<Author> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
