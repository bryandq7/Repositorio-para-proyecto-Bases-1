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



        public static int Agregar(Cuestionario pCuestionario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Cuestionario (Descripcion_cuestionario, activo, cantidad_preguntas, fecha_creacion) values ('{0}','{1}','{2}', '{3}')",
            pCuestionario.Nombre_cuestionario, pCuestionario.activo, pCuestionario.cantidad_preguntas, pCuestionario.Fecha_creacion), Adaptador.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            int ultimo_idCuestionario = Cuestionario_Contr.BuscarIdCuestionario();

            MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into Preguntas (Activo, Pregunta, Puntos, Tipo_Pregunta_idTipo_pregunta,Cuestionario_idCuestionario1) values ('{0}','{1}','{2}','{3}','{4}')",
            pCuestionario.activo, pCuestionario.Pregunta, pCuestionario.Puntos, pCuestionario.idtipo_pregunta, ultimo_idCuestionario ), Adaptador.ObtenerConexion());
            retorno = comando1.ExecuteNonQuery();


            int ultimo_idPregunta = Cuestionario_Contr.BuscarIdPregunta();

            MySqlCommand comando2 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado,Preguntas_id_preguntas) values ('{0}','{1}','{2}');",
            pCuestionario.Respuesta1, pCuestionario.Estado1, ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();


            MySqlCommand comando3 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado,Preguntas_id_preguntas) values ('{0}','{1}','{2}');",
            pCuestionario.Respuesta2, pCuestionario.Estado2,ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando3.ExecuteNonQuery();

            MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado,Preguntas_id_preguntas) values ('{0}','{1}','{2}');",
             pCuestionario.Respuesta3, pCuestionario.Estado3,ultimo_idPregunta), Adaptador.ObtenerConexion());
            retorno = comando4.ExecuteNonQuery();


            MySqlCommand comando5 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado, Preguntas_id_preguntas) values ('{0}','{1}','{2}');",
             pCuestionario.Respuesta4, pCuestionario.Estado4,ultimo_idPregunta), Adaptador.ObtenerConexion());
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
    }
}
