using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos.IRepo
{
    internal interface IRepoFutbolista
    {
        //Guarda Futbolistas
        void AltaFutbolista (Futbolista futbolista);

        //Obtiene una lista de futbolistas 
        List<Futbolista> ObtenerFutbolista();

        //Otiene un futbolista en especifico con atributos determinados por el usuario
        Futbolista? ObtenerFutbolista(short IdFutbolista, string Apodo, decimal Cotizacion );
        

    }
}
