using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.IRepo
{
    internal interface IRepoUsuario
    {
        void AltaUsuario (Usuario usuario, string Contraseña );
        Usuario? UsuarioPorContraseña(short idUsuario, string Contraseña);

    }
}
