using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
