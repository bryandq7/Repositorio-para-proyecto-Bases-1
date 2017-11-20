using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cuestionario_def1
{
    class Cuestionario_Contr
    {



        public static int Agregar(Cuestionario pCuestionario, int num_cuestionario)
        {

            int retorno = 0;

            if (num_cuestionario == 1)
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into Cuestionario (Descripcion_cuestionario, activo, cantidad_preguntas, fecha_creacion) values ('{0}','{1}','{2}', '{3}')",
                pCuestionario.Nombre_cuestionario, pCuestionario.activo, pCuestionario.cantidad_preguntas, pCuestionario.Fecha_creacion), Adaptador.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();


            }
            int ultimo_idCuestionario = Cuestionario_Contr.BuscarIdCuestionario();


            if (num_cuestionario == 1)
            {
                MySqlCommand comando6 = new MySqlCommand(string.Format("Insert into Cuestionario_has_Usuarios (Cuestionario_idCuestionario,Usuarios_sistema_Nombre_usuario, activo, fecha) values ('{0}','{1}','{2}','{3}');",
                ultimo_idCuestionario, pCuestionario.Usuario, pCuestionario.activo, pCuestionario.Fecha_creacion), Adaptador.ObtenerConexion());
                retorno = comando6.ExecuteNonQuery();
            }
            MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into Preguntas (Activo, Pregunta, Puntos, Tipo_Pregunta_idTipo_pregunta,Cuestionario_idCuestionario1) values ('{0}','{1}','{2}','{3}','{4}')",
            pCuestionario.activo, pCuestionario.Pregunta, pCuestionario.Puntos, pCuestionario.idtipo_pregunta, ultimo_idCuestionario ), Adaptador.ObtenerConexion());
            retorno = comando1.ExecuteNonQuery();


            int ultimo_idPregunta = Cuestionario_Contr.BuscarIdPregunta();

            MySqlCommand comando2 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta,Preguntas_id_preguntas) values ('{0}','{1}');",
            pCuestionario.Respuesta1, ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();


            MySqlCommand comando3 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Preguntas_id_preguntas) values ('{0}','{1}');",
            pCuestionario.Respuesta2, ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando3.ExecuteNonQuery();

            MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Preguntas_id_preguntas) values ('{0}','{1}');",
             pCuestionario.Respuesta3, ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando4.ExecuteNonQuery();


            MySqlCommand comando5 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Preguntas_id_preguntas) values ('{0}','{1}');",
             pCuestionario.Respuesta4, ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando5.ExecuteNonQuery();




            return retorno;

        }

        public static int BuscarIdCuestionario()
        {
            int Id_cuestionario=0;

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT MAX(IdCuestionario) FROM Cuestionario"), Adaptador.ObtenerConexion());
            Id_cuestionario = int.Parse(_comando.ExecuteScalar().ToString());
            return Id_cuestionario;
        }

        public static int BuscarIdPregunta()
        {
            int Id_Pregunta = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT MAX(Id_preguntas) FROM Preguntas"), Adaptador.ObtenerConexion());
            Id_Pregunta = int.Parse(_comando.ExecuteScalar().ToString());
            return Id_Pregunta;
        }

        public static List<Cuestionario> Buscar(string pNombre_cuestionario, string pNombre_creador)
        {
            List<Cuestionario> _lista = new List<Cuestionario>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT c.idCuestionario, c.descripcion_cuestionario, c.cantidad_preguntas, c.fecha_creacion, p.Nombre1, p.Apellido1,  p.Apellido2 FROM Cuestionario C " +
                "INNER JOIN Cuestionario_has_usuarios CHU On c.idCuestionario = chu.Cuestionario_idCuestionario " +
                "INNER JOIN Usuarios_sistema U on  chu.Usuarios_sistema_Nombre_usuario = U.Nombre_usuario " +
                "INNER JOIN Cliente Cl  on U.cliente_persona_cedula = Cl.persona_cedula " +
                "INNER JOIN Persona P on Cl.persona_cedula = p.cedula" +
                " where Descripcion_cuestionario = '{0}' or Nombre1 = '{1}'", pNombre_cuestionario, pNombre_creador), Adaptador.ObtenerConexion());

           MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Cuestionario pCuestionario = new Cuestionario();
                pCuestionario.idCuestionario = _reader.GetInt32(0);
                pCuestionario.Nombre_cuestionario = _reader.GetString(1);
                pCuestionario.cantidad_preguntas = _reader.GetInt32(2);
                pCuestionario.Fecha_creacion = _reader.GetString(3);
                pCuestionario.Nombre_creador = _reader.GetString(4);
                pCuestionario.Apellid1_creador = _reader.GetString(5);
                pCuestionario.Apellido2_creador= _reader.GetString(6);
              

                _lista.Add(pCuestionario);
            }
            return _lista;
        }


        public static List<Cuestionario> ObtenerCuestionario(int pidCuestionario)
        {
            List<Cuestionario> _lista = new List<Cuestionario>();

            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT c.idCuestionario, c.descripcion_cuestionario, c.cantidad_preguntas, p.id_preguntas, p.pregunta, p.tipo_pregunta_idtipo_pregunta,  r.idRespuesta, r.Respuesta " +
                "FROM Cuestionario C Join Preguntas P on c.idCuestionario = p.cuestionario_idcuestionario1" +
                " Join Respuesta R on p.id_preguntas = r.preguntas_id_preguntas where idCuestionario={0}", pidCuestionario), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cuestionario pCuestionario = new Cuestionario();
                pCuestionario.idCuestionario = _reader.GetInt32(0);
                pCuestionario.Nombre_cuestionario = _reader.GetString(1);
                pCuestionario.cantidad_preguntas = _reader.GetInt32(2);
                pCuestionario.idPregunta= _reader.GetInt32(3);
                pCuestionario.Pregunta = _reader.GetString(4);
                pCuestionario.idtipo_pregunta = _reader.GetInt32(5);
                pCuestionario.idRespuesta = _reader.GetInt32(6);
                pCuestionario.Respuesta1 = _reader.GetString(7);

                _lista.Add(pCuestionario);

            }

            conexion.Close();
            return _lista;
        }


        public static int Agregar_Resultado_Encuesta(Cuestionario pCuestionario)
        {
            int retorno = 0;

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into Respuesta_encuestado (Respuesta_encuestado, activo, preguntas_id_preguntas, Usuarios_sistema_Nombre_usuario) values ('{0}','{1}','{2}', '{3}')",
                pCuestionario.Respuesta1, pCuestionario.activo, pCuestionario.idPregunta, pCuestionario.Usuario), Adaptador.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            return retorno;

        }

        public static int Agregar_Cuestionario_usuario(Cuestionario pCuestionario)
        {
            int retorno = 0;


                MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into Cuestionario_has_Usuarios (Cuestionario_idCuestionario,Usuarios_sistema_Nombre_usuario, activo, fecha) values ('{0}','{1}','{2}', '{3}')",
                pCuestionario.idCuestionario, pCuestionario.Usuario, pCuestionario.activo, pCuestionario.Fecha_creacion), Adaptador.ObtenerConexion());
                retorno = comando1.ExecuteNonQuery();

            


            return retorno;

        }
    }
}
