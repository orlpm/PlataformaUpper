using System;
using System.Collections.Generic;

namespace APICentralDeTaxis.Models
{
    public partial class Solicitudes
    {
        public int Id { get; set; }
        public int? Folio { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Estatus { get; set; }
        public int? NumeroPasajeros { get; set; }
    }
}
