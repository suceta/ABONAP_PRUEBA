using AbonapProject.Data;
using AbonapProject.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbonapProject.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AbonapDbContext _abodbcontext ;
        public GenericRepository(AbonapDbContext abodbcontext)
        {
            _abodbcontext = abodbcontext ;
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            await _abodbcontext.Set<TEntity>().AddAsync(entity);
            await _abodbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            TEntity entity = await _abodbcontext.Set<TEntity>().FindAsync(id);
            _abodbcontext.Remove(entity);
            return await _abodbcontext.SaveChangesAsync() > 0;
        }

        public async Task<TEntity> FindById(int id)
        {

            return await _abodbcontext.Set<TEntity>().FindAsync(id); 

        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {

           return await _abodbcontext.Set<TEntity>().ToListAsync();

        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _abodbcontext.Entry(entity).State = EntityState.Modified;
            await _abodbcontext.SaveChangesAsync();
            return entity;
        }
    }
}
