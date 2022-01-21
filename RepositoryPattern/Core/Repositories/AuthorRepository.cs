using Microsoft.Extensions.Logging;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(
            ApplicationDbContext context,
            ILogger logger
        ) : base(context, logger)
        {

        }
    }
}
