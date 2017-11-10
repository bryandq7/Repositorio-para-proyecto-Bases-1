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
                pCuestionario.Nombre_cuestionario, pCuestionario.activo, pCuestionario.cantidad_preguntas, pCuestionario.Fecha_creacion ), Adaptador.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();


            MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into Preguntas (activo, Pregunta, Puntos, Tipo_Pregunta_idTipo_pregunta) values ('{0}','{1}','{2}','{3}')",
                pCuestionario.activo, pCuestionario.Pregunta, pCuestionario.Puntos, pCuestionario.tipo_pregunta), Adaptador.ObtenerConexion());
            retorno = comando1.ExecuteNonQuery();


            MySqlCommand comando2 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado) values ('{0}','{1}')",
                pCuestionario.Respuesta1, pCuestionario.Estado1), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();

            MySqlCommand comando3 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado) values ('{0}','{1}')",
             pCuestionario.Respuesta2, pCuestionario.Estado2), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();

            MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado) values ('{0}','{1}')",
             pCuestionario.Respuesta3, pCuestionario.Estado3), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();

            MySqlCommand comando5 = new MySqlCommand(string.Format("Insert into Respuesta (Respuesta, Estado) values ('{0}','{1}')",
             pCuestionario.Respuesta4, pCuestionario.Estado4), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();
            

            return retorno;

        }
    }
}
