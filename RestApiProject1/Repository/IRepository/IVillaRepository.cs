namespace RestApiProject1.Repository.IRepository
{
    public interface IVillaRepository<T> :IRepository<T> where T : class
    {
        public Task UpdateAsync(T item);
      

    }
}
