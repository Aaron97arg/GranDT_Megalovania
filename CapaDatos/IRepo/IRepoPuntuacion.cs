using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos.IRepo
{
    internal interface IRepoPuntuacion
    {
        void AltaPuntuacion(Puntuaciones puntuaciones);
        Puntuaciones? ObtenerPuntuaciones(int IDPuntuacion); 
    }
}