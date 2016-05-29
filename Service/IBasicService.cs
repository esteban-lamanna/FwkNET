using BusinessEntities;
using ViewModelEntities;

namespace Service
{
    public interface IBasicService<TEntity, DVM, EV, EVM, C, FVM, TBusinessService>          
        where TEntity : BusinessEntity, new()
        where DVM : DetailModel, new()
        where EV : EntityExtendedView
        where EVM : ResultModel, new()
        where C : CriteriaEntity, new()
        where FVM : FilterModel,new()
        where TBusinessService : IEntityManagerBusinessService<TEntity, EV, C>
    {
    }
}
