using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public int IdCategoria { get; set; }
        public int Stock {  get; set; }
        public decimal PrecioCompra {  get; set; }
        public decimal PrecioVenta {  get; set; }
        public byte Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        //Proviedades virtuales
        public virtual Categoria Categoria { get; set; }
    }
}
