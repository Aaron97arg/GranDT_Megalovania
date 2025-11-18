using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos.IRepo
{
    internal interface IRepoEquipo
    {
        //Guarda Equipos
        void AltaEquipo(Equipo equipo);

        //Obtiene todos los equipos
        List<Equipo>ObtenerEquipo();

        //Obtiene un Equipo en especifico 
        Equipo? ObtenerEquipo (byte IdEquipo);

    }
}
