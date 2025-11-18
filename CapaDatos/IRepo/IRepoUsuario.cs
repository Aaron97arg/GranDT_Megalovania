using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos.IRepo
{
    internal interface IRepoUsuario
    {
        //Guarda Futbolistas
        void AltaUsuario(Usuario usuario, string Contraseña);
        
        //Otiene un futbolista en especifico con atributos determinados por los parametros Email y contraseña 
        Usuario? UsuarioPorContraseña(string Email, string Contraseña);

    }
}
