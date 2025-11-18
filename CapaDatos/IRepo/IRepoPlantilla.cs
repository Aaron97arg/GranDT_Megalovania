using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos.IRepo
{
    internal interface IRepoPlantilla
    {
        void AltaPlantilla (Plantilla plantilla);
        List<Plantilla> ObtenerPlantillas();
        Plantilla? ObtenerPlantillas(byte IdPlantilla);

    }
}

