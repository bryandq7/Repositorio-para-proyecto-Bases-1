using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cuestionario_def1
{
    class Clientes_Contr
    {
        public static int Agregar(Cliente pCliente)
        {
   
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Persona (cedula, nombre1, nombre2, apellido1, apellido2, activo,  fecha_de_nacimiento, Genero_idGenero) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                pCliente.Cedula, pCliente.Nombre1, pCliente.Nombre2, pCliente.Apellido1, pCliente.Apellido2, pCliente.activo, pCliente.Fecha_Nac, pCliente.id_genero), Adaptador.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
   

            MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into telefono (idtelefono, activo, tipotelefono_idtipotelefono) values ('{0}','{1}','{2}')",
                pCliente.Numero_telefono, pCliente.activo, pCliente.id_tipo_telefono), Adaptador.ObtenerConexion());
            retorno = comando1.ExecuteNonQuery();
   

            MySqlCommand comando2 = new MySqlCommand(string.Format("Insert into correo (nombrecorreo, activo, tipocorreo_idtipocorreo) values ('{0}','{1}','{2}')",
                pCliente.Correo_electronico, pCliente.activo, pCliente.id_tipo_correo), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();
  

            MySqlCommand comando3 = new MySqlCommand(string.Format("Insert into cliente (persona_cedula, tipocliente_idtipocliente, telefono_idtelefono, correo_nombrecorreo, activo) values ('{0}','{1}','{2}','{3}','{4}')",
                pCliente.Cedula, pCliente.id_tipo_cliente, pCliente.Numero_telefono, pCliente.Correo_electronico, pCliente.activo), Adaptador.ObtenerConexion());
            retorno = comando3.ExecuteNonQuery();

            MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into Usuarios_sistema (Nombre_usuario, Contrasena, activo, Tipo_usuario_idTipo_Usuario, cliente_persona_cedula) values ('{0}','{1}','{2}','{3}','{4}')",
            pCliente.Usuario, pCliente.Contrasena, pCliente.activo, pCliente.id_tipo_usuario, pCliente.Cedula), Adaptador.ObtenerConexion());
            retorno = comando4.ExecuteNonQuery();

            return retorno;

        }

        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT p.cedula, p.nombre1, p.nombre2, p.apellido1, p.apellido2, p.activo,  p.fecha_de_nacimiento, p.Genero_idGenero, g.Descripcion, u.Nombre_usuario, Co.Nombrecorreo, t.IdTelefono, tu.Tipo_usuario FROM Persona P INNER JOIN Genero G On p.Genero_idGenero = g.idGenero INNER JOIN Usuarios_sistema U on p.cedula = U.cliente_persona_cedula INNER JOIN Cliente C on p.cedula = C.persona_cedula  INNER JOIN Correo Co on C.correo_nombrecorreo = Co.nombrecorreo INNER JOIN Telefono T on C.telefono_idtelefono = T.idtelefono INNER JOIN Tipo_usuario Tu on U.Tipo_usuario_idTipo_usuario = Tu.idTipo_usuario where Nombre1 = '{0}' or Apellido1 = '{1}'", pNombre, pApellido), Adaptador.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();




            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Cedula = _reader.GetInt32(0);
                pCliente.Nombre1 = _reader.GetString(1);
                pCliente.Nombre2 = _reader.GetString(2);
                pCliente.Apellido1 = _reader.GetString(3); 
                pCliente.Apellido2 = _reader.GetString(4);
                pCliente.activo = _reader.GetInt32(5);
                pCliente.Fecha_Nac = _reader.GetString(6);
                pCliente.id_genero= _reader.GetInt32(7);
                pCliente.Genero = _reader.GetString(8);
                pCliente.Usuario = _reader.GetString(9);
                pCliente.Correo_electronico = _reader.GetString(10);
                pCliente.Numero_telefono = _reader.GetInt32(11);
                pCliente.Descrip_tipousuario = _reader.GetString(12);


                _lista.Add(pCliente);
            }



            return _lista;
        }

        public static Cliente ObtenerCliente(int pCedula)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT cedula, nombre1, nombre2, apellido1, apellido2, activo,  fecha_de_nacimiento, Genero_idGenero FROM Persona where cedula={0}", pCedula), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.Cedula = _reader.GetInt32(0);
                pCliente.Nombre1 = _reader.GetString(1);
                pCliente.Nombre2 = _reader.GetString(2);
                pCliente.Apellido1 = _reader.GetString(3);
                pCliente.Apellido2 = _reader.GetString(4);
                pCliente.activo = _reader.GetInt32(5);
                pCliente.Fecha_Nac = _reader.GetString(6);
                pCliente.id_genero = _reader.GetInt32(7);

            }

            conexion.Close();
            return pCliente;

        }

        public static int Actualizar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update Persona set Nombre1='{0}', Nombre2='{1}', Apellido1='{2}', Apellido2='{3}', activo='{4}',fecha_de_nacimiento='{5}', Genero_idGenero='{6}' where Cedula={7}",
                pCliente.Nombre1, pCliente.Nombre2, pCliente.Apellido1, pCliente.Apellido2, pCliente.activo, pCliente.Fecha_Nac, pCliente.id_genero, pCliente.Cedula), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static bool Revisar_cedula(int cedula)
        {
            int count = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("Select cedula from persona where Cedula={0}",
                cedula), Adaptador.ObtenerConexion());

            count = Convert.ToInt32(_comando.ExecuteScalar());

            if (count == 0)
            {
                return false;
            }

            return true;


        }

        public static bool Revisar_usuario(string usuario)
        {
            int count = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("Select count(*) nombre_usuario from usuarios_sistema where Nombre_usuario = '{0}'",
                usuario), Adaptador.ObtenerConexion());

            count = Convert.ToInt32(_comando.ExecuteScalar());


            if (count == 0)
            {
                return false;
            }

            return true;

           


        }

        public static bool Revisar_correo(string correo)
        {
            int count = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("Select count(*) nombrecorreo from Correo where nombreCorreo = '{0}'",
                correo), Adaptador.ObtenerConexion());

            count = Convert.ToInt32(_comando.ExecuteScalar());


            if (count == 0)
            {
                return false;
            }

            return true;




        }

        public static bool Revisar_telefono(int telefono)
        {
            int count = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("Select count(*) idtelefono from telefono where idtelefono = '{0}'",
                telefono), Adaptador.ObtenerConexion());

            count = Convert.ToInt32(_comando.ExecuteScalar());


            if (count == 0)
            {
                return false;
            }

            return true;




        }




    }
}
