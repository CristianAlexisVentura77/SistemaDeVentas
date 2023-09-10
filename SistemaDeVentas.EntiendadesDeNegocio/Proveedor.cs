﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.EntiendadesDeNegocio
{
    public class Proveedor
    {
       public int Id { get; set; }
        public string Documento { get; set; }
        public string RazonSocial { get; set; }
        public string Correo {  get; set; }
        public string Telefono {  get; set; }
        public byte Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
