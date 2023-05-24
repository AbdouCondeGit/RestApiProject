using DataAccess;
using Models;
using RestApiProject1.Repository.IRepository;

namespace RestApiProject1.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository<Villa>
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public async Task UpdateAsync(Villa item)
        {
            _db.Villas.Update(item);
        }
    }
}
