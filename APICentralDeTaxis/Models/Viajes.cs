using System;
using System.Collections.Generic;

namespace APICentralDeTaxis.Models
{
    public partial class Viajes
    {
        public int Id { get; set; }
        public int? Folio { get; set; }
        public string Estatus { get; set; }
        public string Notas { get; set; }
        public string Incidentes { get; set; }
        public int? NumeroPasajeros { get; set; }
        public string IdSolicitud { get; set; }
        public string IdConductor { get; set; }
        public string IdVehiculo { get; set; }
        public int? Tarifa { get; set; }
        public int? Kilometros { get; set; }
        public int? TiempoDeViaje { get; set; }
    }
}
