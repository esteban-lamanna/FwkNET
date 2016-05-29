using BusinessEntities.Persona;
using Repository.Persona;

namespace Logic
{
    public class PersonaLogic : EntityManagerLogic<PersonaEntity, PersonaExtendedView,PersonaCriteria, IPersonaRepository>
    {
        public PersonaLogic(IPersonaRepository Repository)
            : base(Repository) { }

    }
}
