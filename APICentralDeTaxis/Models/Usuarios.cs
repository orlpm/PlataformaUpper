using System;
using System.Collections.Generic;

namespace APICentralDeTaxis.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public int? Folio { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
    }
}
