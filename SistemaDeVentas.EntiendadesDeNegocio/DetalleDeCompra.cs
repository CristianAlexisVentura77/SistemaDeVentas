using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class DetalleDeCompra
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad {  get; set; }
        public decimal SubTotal { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
