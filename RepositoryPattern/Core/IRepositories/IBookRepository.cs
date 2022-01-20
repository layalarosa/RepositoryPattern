using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepositories
{
    interface IBookRepository : IGenericRepository<Book>
    {
    }
}
