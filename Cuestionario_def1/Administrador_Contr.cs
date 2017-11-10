using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cuestionario_def1
{
    class Administrador_Contr
    {

        //public static int Agregar(Administrador pAdmin)
        //{

        //    int retorno = 0;

        //    MySqlCommand comando = new MySqlCommand(string.Format("Insert into Persona (cedula, nombre1, nombre2, apellido1, apellido2, activo,  fecha_de_nacimiento, Genero_idGenero) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
        //        pAdmin.Cedula, pAdmin.Nombre1, pAdmin.Nombre2, pAdmin.Apellido1, pAdmin.Apellido2, pAdmin.activo, pAdmin.Fecha_Nac, pAdmin.id_genero), Adaptador.ObtenerConexion());
        //    retorno = comando.ExecuteNonQuery();


        //    MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into telefono (idtelefono, activo, tipotelefono_idtipotelefono) values ('{0}','{1}','{2}')",
        //        pAdmin.Numero_telefono, pAdmin.activo, pAdmin.id_tipo_telefono), Adaptador.ObtenerConexion());
        //    retorno = comando1.ExecuteNonQuery();


        //    MySqlCommand comando2 = new MySqlCommand(string.Format("Insert into correo (nombrecorreo, activo, tipocorreo_idtipocorreo) values ('{0}','{1}','{2}')",
        //        pAdmin.Correo_electronico, pAdmin.activo, pAdmin.id_tipo_correo), Adaptador.ObtenerConexion());
        //    retorno = comando2.ExecuteNonQuery();


        //    MySqlCommand comando3 = new MySqlCommand(string.Format("Insert into cajero (salario, fechadeingreso, activo, tipocajero_idtipocajero, telefono_idtelefono, persona_cedula1, correo_nombrecorreo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
        //        pAdmin.Salario, pAdmin.Fecha_Ing, pAdmin.activo, pAdmin.id_tipo_cajero, pAdmin.Numero_telefono,pAdmin.Cedula,pAdmin.Correo_electronico), Adaptador.ObtenerConexion());
        //    retorno = comando3.ExecuteNonQuery();

        //    MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into Usuarios_sistema (persona_cedula, Nombre_usuario, Contrasena, activo, Tipo_usuario_idTipo_Usuario) values ('{0}','{1}','{2}','{3}','{4}')",
        //    pAdmin.Cedula, pAdmin.Usuario, pAdmin.Contrasena, pAdmin.activo, pAdmin.id_tipo_usuario), Adaptador.ObtenerConexion());
        //    retorno = comando4.ExecuteNonQuery();

        //    return retorno;

        //}


    }
}

