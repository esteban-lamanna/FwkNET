using BusinessEntities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
