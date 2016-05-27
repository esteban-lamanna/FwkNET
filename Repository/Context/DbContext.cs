using BusinessEntities.Persona;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<PersonaEntity> Personas { get; set; }
    }
}
