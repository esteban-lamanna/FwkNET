using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TBusinessEntity, EV, C>
        where TBusinessEntity : BusinessEntity, new()
        where EV : EntityExtendedView, new()
        where C : CriteriaEntity
    {
        List<EV> ReadExtendedViewByCriteria(C criteriaEntity);
        EV Add(TBusinessEntity entity);
        void Delete(TBusinessEntity entity);
        EV Update(TBusinessEntity entity);
    }
}
