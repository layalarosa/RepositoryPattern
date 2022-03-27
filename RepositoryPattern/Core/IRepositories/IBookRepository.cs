using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepositories
{
    interface IBookRepository : IGenericRepository<Book>
    {
        public Task<bool> Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<Book>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
