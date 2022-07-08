using AbonapProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Models
{
    public class PrestamosViewModel
    {
        public Prestamos Prestamo { get; set; }
        public string NombreCliente  {get; set;}
        public string NombreSucursal { get; set; }

    }
}
