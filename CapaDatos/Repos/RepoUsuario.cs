 
using System.Data;
using Dapper;
using CapaEntidad;
using CapaDatos.IRepo;
using System.Formats.Asn1;
using Super.Dapper;

namespace CapaDatos;

public class RepoUsuario : Repo, IRepoUsuario
{
    private static readonly string 
    = @" SELECT idUsuario, nombre , apellido, email, fechaNac, contraseña, es_admin
         FROM Usuario 
         WHERE idUsuario =  ";


    public RepoUsuario(IDbConnection conexion)
       : base(conexion) { }

    
}