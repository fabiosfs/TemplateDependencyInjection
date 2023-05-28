using Microsoft.EntityFrameworkCore;
using System;
using TemplateDependencyInjection.Domain.Entities;
using TemplateDependencyInjection.Domain.Interfaces;

namespace TemplateDependencyInjection.Infrastructure.Repositories
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity : BaseEntity where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(TContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancel)
        {
            var records = await _dbSet.Select(x => x).ToListAsync(cancel);
            return records;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id, CancellationToken cancel)
        {
            var record = await _dbSet.FirstOrDefaultAsync(_ => _.Id == id, cancel);
            return record;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancel)
        {
            entity.CreateDate();
            entity.UpdateDate();
            await _dbSet.AddAsync(entity, cancel);
            await _context.SaveChangesAsync(cancel);
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancel)
        {
            entity.UpdateDate();
            _dbSet.Update(entity);
            _context.Entry(entity).Property(x => x.Created).IsModified = false;
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> DeleteAsync(int id, CancellationToken cancel)
        {
            var entity = await GetByIdAsync(id, cancel);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(cancel);
            return entity;
        }
    }
}
