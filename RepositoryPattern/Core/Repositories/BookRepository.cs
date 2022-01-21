using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(
            ApplicationDbContext context,
            ILogger logger
        ) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<Book>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(BookRepository));
                return new List<Book>();
            }
        }

        public override async Task<bool> Update(Book entity)
        {
            try
            {
                var existingBook = await dbSet.Where(x => x.Id == entity.Id)
                                                        .FirstOrDefaultAsync();

                if (existingBook == null)
                    return await Add(entity);

                existingBook.Title = entity.Title;
                existingBook.Price = entity.Price;
                existingBook.Year = entity.Year;
                existingBook.Genre = entity.Genre;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert method error", typeof(BookRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.Id == id)
                                    .FirstOrDefaultAsync();

                if (exist != null)
                {
                    dbSet.Remove(exist);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete method error", typeof(BookRepository));
                return false;
            }
        }
    }
}
