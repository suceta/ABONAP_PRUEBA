using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Data.Entities
{
    public class Prestamos
    {
        [Key]
        public int IdPrestamo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public int IdCliente { get; set; }
        public int idSucursal { get; set; }
        public double Monto { get; set; }
    }
}
