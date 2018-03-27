using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MuenYang.SMZG.EntityFramework.Repositories
{
    public abstract class SMZGRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SMZGDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SMZGRepositoryBase(IDbContextProvider<SMZGDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SMZGRepositoryBase<TEntity> : SMZGRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SMZGRepositoryBase(IDbContextProvider<SMZGDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
