using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoApp.Models
{
    public class SucursalModel
    {
        public string idSucursal { get; set; }
        public string idBanco { get; set; }
        public string nombreSucursal { get; set; }
        public string direccionSucursal { get; set; }
        public DateTime fecRegistro { get; set; }

    }
}
