using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class FutbolistaPlantilla
    {
        public byte IdFutbolistaPlantilla { get; set; }
        public byte futbolista_titulares { get; set; }
        public byte futbolista_suplentes { get; set; }
        public byte fk_idPlantilla { get; set; }
        public short fk_idFutbolista { get; set; }
        public int validacionP { get; set; }
        public int validacionR { get; set; }

    }
}
