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
  

            MySqlCommand comando3 = new MySqlCommand(string.Format("Insert into cliente (tipocliente_idtipocliente, telefono_idtelefono, persona_cedula, correo_nombrecorreo, activo) values ('{0}','{1}','{2}','{3}','{4}')",
                pCliente.id_tipo_cliente, pCliente.Numero_telefono, pCliente.Cedula, pCliente.Correo_electronico, pCliente.activo), Adaptador.ObtenerConexion());
            retorno = comando3.ExecuteNonQuery();

            MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into Usuarios_sistema (persona_cedula, Nombre_usuario, Contrasena, activo, Tipo_usuario_idTipo_Usuario) values ('{0}','{1}','{2}','{3}','{4}')",
            pCliente.Cedula, pCliente.Usuario, pCliente.Contrasena, pCliente.activo, pCliente.id_tipo_usuario), Adaptador.ObtenerConexion());
            retorno = comando4.ExecuteNonQuery();

            return retorno;

        }

        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT cedula, nombre1, nombre2, apellido1, apellido2, activo,  fecha_de_nacimiento, Genero_idGenero FROM Persona  where Nombre1 ='{0}' or Apellido1='{1}'", pNombre, pApellido), Adaptador.ObtenerConexion());
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


    }
}
