using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int IdRol { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaRegistro { get; set; }


        //Proviedades virtuales
        public virtual Rol Rol { get; set; }

    }
}
