using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class DetalleDeVenta
    {
        public int Id { get; set; }
        public int IdCompra {  get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }

        //Proviedades virtuales
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
