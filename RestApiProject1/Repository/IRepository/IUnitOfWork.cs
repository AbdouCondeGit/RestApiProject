using Models;

namespace RestApiProject1.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public Task CommitAsync();
        IVillaRepository<Villa> villaRepository { get; }
        IVillaValueRepository<VillaValue> villaValueRepository { get; }
        IUserRepository<ApplicationUser> userRepository { get; }
        
    }
}
