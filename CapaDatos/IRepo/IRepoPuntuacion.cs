using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.IRepo
{
    internal interface IRepoPuntuacion
    {
        void AltaPuntuacion(Puntuaciones puntuaciones);
        Puntuaciones? ObtenerPuntuaciones(int IDPuntuacion); 
    }
}