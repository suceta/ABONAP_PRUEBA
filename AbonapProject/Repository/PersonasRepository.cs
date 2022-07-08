using AbonapProject.Data;
using AbonapProject.Data.Entities;
using AbonapProject.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Repository
{
    public class PersonasRepository : GenericRepository<Personas>, IPersonasRepository
    {
        public PersonasRepository(AbonapDbContext dbContext) : base(dbContext) 
        {

        }
    
    }
}
