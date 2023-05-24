using DataAccess;
using Microsoft.EntityFrameworkCore;
using RestApiProject1.Repository.IRepository;
using System.Linq.Expressions;

namespace RestApiProject1.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();

        }
        public async Task CreateAsync(T item)
        {
            await _dbSet.AddAsync(item);
           // _db.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, string? includeNaviProperties = null)
        {
            IQueryable<T> queryable = _dbSet;
            if(filter != null)
            {
                queryable = queryable.Where(filter);
            }
            if(includeNaviProperties != null)
            {
                foreach (string navigationProperty in includeNaviProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    queryable.Include(navigationProperty);
                }
            }
            

            return queryable.ToListAsync().GetAwaiter().GetResult();
            
        }

        public async Task<T> getAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeNaviProperties = null)
        {
            IQueryable<T> queryable = _dbSet;
            if (!tracked)
            {
                queryable=queryable.AsNoTracking(); //Pour ne pas embrouiller EF quand il recupera de trouver un élément pour mis à jour...
            }
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }
            if (includeNaviProperties != null)
            {
                foreach (string navigationProperty in includeNaviProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    queryable.Include(navigationProperty);
                }
            }
            
            return  queryable.FirstOrDefaultAsync().GetAwaiter().GetResult();
        }

        public async Task RemoveAsync(T item)
        {
             _dbSet.Remove(item);
           // _db.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> items)
        {
            _dbSet.RemoveRange(items);
            //_db.SaveChangesAsync();
        }
    }
}
