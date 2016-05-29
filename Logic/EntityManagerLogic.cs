using BusinessEntities;
using Repository;
using System;
using System.Collections.Generic;

namespace Logic
{
    public abstract class EntityManagerLogic<TEntity, EV, C, TRepository> : IBusinessLogic<TEntity, EV, C, TRepository>
        where TEntity : BusinessEntity, new()
        where EV : EntityExtendedView, new()
        where C : CriteriaEntity
        where TRepository : IRepository<TEntity, EV, C>
    {
        TRepository Repository { get; set; }

        protected EntityManagerLogic(TRepository repository)
        {

        }

        public TEntity Read(long ID)
        {
            throw new NotImplementedException();
        }

        public List<EV> ReadExtendedViewByCriteria(C criteria)
        {
            return this.Repository.ReadExtendedViewByCriteria(criteria);
        }
    }
}
