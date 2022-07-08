using AbonapProject.Data;
using AbonapProject.Data.Entities;
using AbonapProject.Models;
using AbonapProject.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Repository
{
    public class PrestamosRepository : GenericRepository<Prestamos>, IPrestamosRepository
    {
        AbonapDbContext _dbcontext;
        public PrestamosRepository(AbonapDbContext dbcontext) : base(dbcontext) 
        {
            _dbcontext = dbcontext;
        }
    }
}
