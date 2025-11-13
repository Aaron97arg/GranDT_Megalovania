using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Plantilla
    {
        public byte IdPlantilla { get; set; }
        public required string NombreP { get; set; }
        public decimal CantMaxMonto { get; set; }
        public byte CantMaxFutbolista { get; set; }
        public short IdUsuario { get; set; }
        public int IdPuntuacion { get; set; } //son foreignkey 

    }
}
