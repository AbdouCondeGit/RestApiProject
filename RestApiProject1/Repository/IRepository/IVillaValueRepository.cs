using Models;

namespace RestApiProject1.Repository.IRepository
{
    public interface IVillaValueRepository<T> : IRepository<T> where T : class
    {
        public Task<VillaValue> UpdateAsync(T item);

    }
}
