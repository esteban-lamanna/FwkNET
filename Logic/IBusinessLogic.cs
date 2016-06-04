using BusinessEntities;
using Repository;
using System.Collections.Generic;

namespace Logic
{
    public interface IBusinessLogic<TEntity, EV, C, TRepository>
        where TEntity : BusinessEntity,new()
        where EV : EntityExtendedView , new()
        where C : CriteriaEntity
        where TRepository : IRepository<TEntity, EV, C> 
    {
        List<EV> ReadExtendedViewByCriteria(C criteria);
        TEntity Read(long ID);
        EV Add(TEntity entity);
        void Delete(long ID);
    }
}
