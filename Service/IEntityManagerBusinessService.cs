using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IEntityManagerBusinessService<TEntity, EV, C> 
       where TEntity : BusinessEntity
       where EV : EntityExtendedView
       where C : CriteriaEntity    
    {
    }
}
