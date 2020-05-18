using System;
using System.Collections.Generic;

namespace APICentralDeTaxis.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Notas { get; set; }
        public int? NumeroViajes { get; set; }
    }
}
