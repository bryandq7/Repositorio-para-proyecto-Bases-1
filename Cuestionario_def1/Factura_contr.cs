using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cuestionario_def1
{
    class Factura_contr
    {

        public static List<Factura> Buscar(int pcedula, string cfecha_creacion)
        {
            List<Factura> _lista = new List<Factura>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT c.idCuestionario, c.descripcion_cuestionario, c.cantidad_preguntas, c.fecha_creacion,p.cedula, p.Nombre1, p.Apellido1,  p.Apellido2 FROM Cuestionario C " +
                "INNER JOIN Cuestionario_has_usuarios CHU On c.idCuestionario = chu.Cuestionario_idCuestionario " +
                "INNER JOIN Usuarios_sistema U on  chu.Usuarios_sistema_Nombre_usuario = U.Nombre_usuario " +
                "INNER JOIN Cliente Cl  on U.cliente_persona_cedula = Cl.persona_cedula " +
                "INNER JOIN Persona P on Cl.persona_cedula = p.cedula" +
                " where cedula = '{0}' and fecha_creacion = '{1}' and c.activo = '{2}' ", pcedula, cfecha_creacion,1), Adaptador.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Factura pFactura = new Factura();
                pFactura.idCuestionario = _reader.GetInt32(0);
                pFactura.Nombre_cuestionario = _reader.GetString(1);
                pFactura.cantidad_preguntas = _reader.GetInt32(2);
                pFactura.Fecha_creacion = _reader.GetString(3);
                pFactura.cedula = _reader.GetInt32(4);
                pFactura.Nombre_creador = _reader.GetString(5);
                pFactura.Apellid1_creador = _reader.GetString(6);
                pFactura.Apellido2_creador = _reader.GetString(7);


                _lista.Add(pFactura);
            }
            return _lista;
        }


        public static List<Factura> ObtenerFactura(int pidFactura)
        {
            List<Factura> _lista = new List<Factura>();

            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT f.idfactura, f.detalle, p.cedula, p.Nombre1, p.Apellido1, p.Apellido2, dt.idLinea, dt.cantidad, dt.precio, dt.subtotal, dt.detalle, dt.cuestionario_idCuestionario, f.fecha " +
                "FROM Factura F  Join detallefactura dt on f.idFactura = dt.Factura_idFactura " +
                "Join Cliente C on f.cliente_persona_cedula = c.persona_cedula " +
                "Join Persona P  on p.cedula = c.persona_cedula " +
                " where f.idfactura={0} ", pidFactura), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Factura pFactura = new Factura();
                pFactura.idFactura = _reader.GetInt32(0);
                pFactura.Nombre_cuestionario = _reader.GetString(1);
                pFactura.cedula = _reader.GetInt32(2);
                pFactura.Nombre_creador = _reader.GetString(3);
                pFactura.Apellid1_creador = _reader.GetString(4);
                pFactura.Apellido2_creador = _reader.GetString(5);
                pFactura.idlinea = _reader.GetInt32(6);
                pFactura.cantidad_preguntas = _reader.GetInt32(7);
                pFactura.precio = _reader.GetInt32(8);
                pFactura.sub_total = _reader.GetInt32(9);
                pFactura.detalle_linea= _reader.GetString(10);
                pFactura.idCuestionario= _reader.GetInt32(11);
                pFactura.Fecha_creacion = _reader.GetString(12);



                _lista.Add(pFactura);

            }

            conexion.Close();
            return _lista;
        }

        //public static List<Factura> ObtenerFactura(int pidCuestionario)
        //{
        //    List<Factura> _lista = new List<Factura>();

        //    MySqlConnection conexion = Adaptador.ObtenerConexion();

        //    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT c.idCuestionario, c.descripcion_cuestionario, c.cantidad_preguntas, p.id_preguntas, p.pregunta, p.tipo_pregunta_idtipo_pregunta,  r.idRespuesta, r.Respuesta " +
        //        "FROM Cuestionario C Join Preguntas P on c.idCuestionario = p.cuestionario_idcuestionario1" +
        //        " Join Respuesta R on p.id_preguntas = r.preguntas_id_preguntas where idCuestionario={0}", pidCuestionario), conexion);
        //    MySqlDataReader _reader = _comando.ExecuteReader();
        //    while (_reader.Read())
        //    {
        //        Cuestionario pCuestionario = new Cuestionario();
        //        pCuestionario.idCuestionario = _reader.GetInt32(0);
        //        pCuestionario.Nombre_cuestionario = _reader.GetString(1);
        //        pCuestionario.cantidad_preguntas = _reader.GetInt32(2);
        //        pCuestionario.idPregunta = _reader.GetInt32(3);
        //        pCuestionario.Pregunta = _reader.GetString(4);
        //        pCuestionario.idtipo_pregunta = _reader.GetInt32(5);
        //        pCuestionario.idRespuesta = _reader.GetInt32(6);
        //        pCuestionario.Respuesta1 = _reader.GetString(7);

        //        _lista.Add(pCuestionario);

        //    }

        //    conexion.Close();
        //    return _lista;
        //}

        public static int Agregar(Factura pFactura, int num_cuestionario)
        {

            int retorno = 0;

            if (num_cuestionario == 1)
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into Factura (fecha, monto, detalle,  estatusfactura, cliente_persona_cedula) values ('{0}','{1}','{2}', '{3}', '{4}')",
                pFactura.Fecha_creacion, pFactura.monto_total, "Cancelacion de factura", pFactura.activo, pFactura.cedula), Adaptador.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            int ultimo_idFactura = Factura_contr.BuscarIdFactura();


            MySqlCommand comando2 = new MySqlCommand(string.Format("Insert into detallefactura (Cantidad,Precio,subtotal,detalle,Factura_idFactura,Cuestionario_idCuestionario) values ('{0}','{1}','{2}','{3}','{4}','{5}');",
            pFactura.cantidad_preguntas, pFactura.precio,pFactura.sub_total,pFactura.Nombre_cuestionario, ultimo_idFactura,pFactura.idCuestionario), Adaptador.ObtenerConexion());
            retorno = comando2.ExecuteNonQuery();

            double monto_factura = Factura_contr.Buscar_monto_Factura(ultimo_idFactura);

            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand comando3 = new MySqlCommand(string.Format("Update Factura set Monto='{0}' where idFactura={1}",
            monto_factura, ultimo_idFactura), conexion);

            retorno = comando3.ExecuteNonQuery();

            conexion.Close();



            return retorno;

        }

        public static int BuscarIdFactura()
        {
            int Id_Factura = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT MAX(IdFactura) FROM Factura"), Adaptador.ObtenerConexion());
            Id_Factura = int.Parse(_comando.ExecuteScalar().ToString());
            return Id_Factura;
        }


        public static double Buscar_monto_Factura(int id_factura)
        {
            double Monto_factura = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT SUM(subtotal) FROM detallefactura WHERE factura_idfactura = '{0}' ", id_factura), Adaptador.ObtenerConexion());

            Monto_factura = double.Parse(_comando.ExecuteScalar().ToString());

            return Monto_factura;
        }

        public static int Pagar_factura(int id_factura)
        {
            int retorno = 0;

            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand comando3 = new MySqlCommand(string.Format("Update Factura set estatusfactura='{0}' where idFactura={1}",
            2, id_factura), conexion);

            retorno = comando3.ExecuteNonQuery();
            //MySqlCommand comando4 = new MySqlCommand(string.Format("Update Cuestionario set activo='{0}' where idCuestionario={1}",
            //2, id_cuestionario), conexion);

            //retorno = comando4.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Pagar_Cuestionario(int id_cuestionario)
        {
            int retorno = 0;

            MySqlConnection conexion = Adaptador.ObtenerConexion();

            MySqlCommand comando4 = new MySqlCommand(string.Format("Update Cuestionario set activo='{0}' where idCuestionario={1}",
            2, id_cuestionario), conexion);

            retorno = comando4.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Agregar_Resultado_Encuesta(Cuestionario pCuestionario)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Respuesta_encuestado (Respuesta_encuestado, activo, preguntas_id_preguntas, Usuarios_sistema_Nombre_usuario) values ('{0}','{1}','{2}', '{3}')",
            pCuestionario.Respuesta1, pCuestionario.activo, pCuestionario.idPregunta, pCuestionario.Usuario), Adaptador.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;

        }
    }
}
