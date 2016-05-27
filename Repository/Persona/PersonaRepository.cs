using BusinessEntities.Persona;
using Repository.Context;
using Repository.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonaRepository : BasicRepository<PersonaEntity, PersonaExtendedView, PersonaCriteria>, IPersonaRepository 
    {        
    }
}
