using System;
using System.Collections.Generic;

namespace APICentralDeTaxis.Models
{
    public partial class Conductores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public string Zona { get; set; }
        public int? NumeroServicios { get; set; }
    }
}
