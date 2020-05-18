using System;
using System.Collections.Generic;

namespace APICentralDeTaxis.Models
{
    public partial class Taxis
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int? Telefono { get; set; }
        public string Notas { get; set; }
        public int? NumeroViajes { get; set; }
    }
}
