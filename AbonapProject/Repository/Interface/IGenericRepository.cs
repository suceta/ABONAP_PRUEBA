using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Repository.Interface
{
    public interface IGenericRepository<TEntity>  where TEntity : class
    {
        Task<TEntity> Create(TEntity entity);

        Task<bool> Delete(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> FindById(int id);

        Task<TEntity> Update(TEntity entity);



    }
}
