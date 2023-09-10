using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class Compra
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
