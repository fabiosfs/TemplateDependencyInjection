namespace TemplateDependencyInjection.Domain.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancel);
        public Task<TEntity> GetByIdAsync(int id, CancellationToken cancel);
        public Task<TEntity> CreateAsync(TEntity data, CancellationToken cancel);
        public Task<TEntity> UpdateAsync(TEntity data, CancellationToken cancel);
        public Task<TEntity> DeleteAsync(int id, CancellationToken cancel);
    }
}
