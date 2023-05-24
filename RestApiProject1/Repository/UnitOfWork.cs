using DataAccess;
using Models;
using RestApiProject1.Repository.IRepository;

namespace RestApiProject1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IVillaRepository<Villa> villaRepository { get; set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            villaRepository=new VillaRepository(db);
            this._db = db;
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
