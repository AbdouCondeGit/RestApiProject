using DataAccess;
using Models;
using RestApiProject1.Repository.IRepository;

namespace RestApiProject1.Repository
{
    public class VillaValueRepository : Repository<VillaValue>, IVillaValueRepository<VillaValue>
    {
        private readonly ApplicationDbContext _db;
        public VillaValueRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<VillaValue> UpdateAsync(VillaValue entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaValues.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
