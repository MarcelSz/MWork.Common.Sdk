using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MWork.Common.Sdk.Repositories.Types;

namespace MWork.Common.Sdk.Repositories
{
    public interface IDataRepository<TEntity> where TEntity : IWithId
    {
        Task Create(TEntity entity);
        
        Task<TEntity> GetOne(Guid id);

        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter);

        Task Update(Guid id, Action<TEntity> changes);

        Task Update(TEntity entity);
        
        Task Delete(Guid id);
    }
}