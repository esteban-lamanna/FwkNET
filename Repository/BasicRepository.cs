using BusinessEntities;
using System;
using System.Collections.Generic;

namespace Repository
{
    public abstract class BasicRepository<TEntity, EV, C> : IRepository<TEntity,EV,C>
        where TEntity : BusinessEntity, new()
        where EV : EntityExtendedView, new()
        where C : CriteriaEntity
    {

        public List<EV> ReadExtendedViewByCriteria(C criteriaEntity)
        {
            throw new NotImplementedException();
        }

        public EV Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public EV Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long ID)
        {
            throw new NotImplementedException();
        }
    }
}
