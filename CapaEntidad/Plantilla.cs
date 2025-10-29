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
        public int cantMaxMonto { get; set; }
        public required string NombreP { get; set; }
        public byte cantMaxFutbolista { get; set; }
        public short fk_idUsuario { get; set; }
        public int fk_idPuntuacion { get; set; }

    }
}
