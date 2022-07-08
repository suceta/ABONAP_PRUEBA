using AbonapProject.Data.Entities;
using AbonapProject.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Services
{
    public class PrestamosServices
    {
        private readonly IPrestamosRepository _pretamorepos;
        public PrestamosServices(IPrestamosRepository pretamorepos)
        {
            _pretamorepos = pretamorepos;
        }

        public async Task<IEnumerable<Prestamos>> GetAll() 
        {
            return await _pretamorepos.GetAll();
        }

        public async Task<Prestamos> Create(Prestamos prestamo)
        {
            return await _pretamorepos.Create(prestamo);
        }

        public async Task<bool> Delete(int id)
        {
            return await _pretamorepos.Delete(id);
        }

        public async Task<Prestamos> FindOneById (int id)
        {
            return await _pretamorepos.FindById(id);
        }

        public async Task<Prestamos> Update(Prestamos prestamo)
        {
            // Prestamos prestamo = await FindOneById(id);
            return await _pretamorepos.Update(prestamo);
        }
    }
}
