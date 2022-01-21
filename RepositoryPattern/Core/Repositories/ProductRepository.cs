using Microsoft.Extensions.Logging;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(
            ApplicationDbContext context,
            ILogger logger
        ) : base(context, logger)
        {

        }
    }
}
