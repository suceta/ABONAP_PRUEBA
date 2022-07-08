using AbonapProject.Data.Entities;
using AbonapProject.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Services
{


    public class PersonasServices
    {
        private readonly IPersonasRepository _personrepos;
        public PersonasServices(IPersonasRepository personrepos)
        {
            _personrepos = personrepos;
        }

        public async Task<IEnumerable<Personas>> GetAll()
        {
            return await _personrepos.GetAll();
        }

        public async Task<Personas> Create(Personas persona)
        {
            return await _personrepos.Create(persona);
        }

        public async Task<bool> Delete(int id)
        {
            return await _personrepos.Delete(id);
        }

        public async Task<Personas> FindOneById(int id)
        {
            return await _personrepos.FindById(id);
        }

        public async Task<Personas> Update(Personas persona)
        {

            return await _personrepos.Update(persona);
        }
    }
}
