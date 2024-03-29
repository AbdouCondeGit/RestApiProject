﻿using System.Linq.Expressions;

namespace RestApiProject1.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        public Task CreateAsync(T item);
        public Task<T> getAsync(Expression<Func<T,bool>> filter=null, bool tracked=true,string? includeNaviProperties=null);
        public Task<List<T>> GetAllAsync(int pageSize, int pageNumber, string? includeNaviProperties = null);

        public Task RemoveAsync(T item);
        public Task RemoveRangeAsync(IEnumerable<T> items);

    }
}
