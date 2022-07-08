using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbonapProject.Data.Entities
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Codigo { get; set; }
        public bool Estado { get; set; }
        public int IdPersona { get; set; }
        public int idSucursal { get; set; }
    }
}
