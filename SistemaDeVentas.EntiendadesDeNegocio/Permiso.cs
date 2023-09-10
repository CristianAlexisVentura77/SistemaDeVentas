using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class Permiso
    {
        public int Id { get; set; }
        public int IdRol {  get; set; }
        public string NombreMenu { get; set; }
        public DateTime FechaRegistro { get; set; }


        //Proviedades virtuales
        public virtual Rol Rol { get; set; }
    }
}
