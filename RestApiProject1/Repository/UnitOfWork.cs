using DataAccess;
using Models;
using RestApiProject1.Repository.IRepository;

namespace RestApiProject1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IVillaRepository<Villa> villaRepository { get; set; }
        public IVillaValueRepository<VillaValue> villaValueRepository { get; set; }

        public IUserRepository<ApplicationUser> userRepository { get; set; }
        IConfiguration _configuration;

        public UnitOfWork(ApplicationDbContext db, IConfiguration configuration)
        {
            this._db = db;
            _configuration = configuration;
            villaRepository =new VillaRepository(db);
            villaValueRepository=new VillaValueRepository(db);
            userRepository =new UserRepository(db,configuration);
           
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
