using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuestionario_def1
{
    public class Adaptador
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;port=3307;database=cuestionariomejorado; Uid=root;pwd=123456;");
            conexion.Open();
            return conexion;
        }

        public static MySqlConnection CerrarConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;port=3307;database=cuestionariomejorado; Uid=root;pwd=123456;");
            conexion.Close();
            return conexion;
        }



        public void llenarComboBox_genero (ComboBox Combo_genero)      {
            MySqlConnection con = ObtenerConexion();

            MySqlCommand cm = new MySqlCommand("select * from genero;", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Combo_genero.ValueMember = "idGenero";
            Combo_genero.DisplayMember="Descripcion";
            Combo_genero.DataSource = dt;
        }

        public void Seleccionado_ComboBox_genero(ComboBox Combo_genero, int id_genero)
        {
            MySqlConnection con = ObtenerConexion();

            MySqlCommand cm = new MySqlCommand("select * from genero where idGenero = "+id_genero+";", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Combo_genero.ValueMember = "idGenero";
            Combo_genero.DisplayMember = "Descripcion";
            Combo_genero.DataSource = dt;
        }

        public void llenarComboBox_tipo_Telefono(ComboBox Combo_tipo_telefono)
        {
            MySqlConnection con = Adaptador.ObtenerConexion();
            MySqlCommand cm = new MySqlCommand("select * from tipotelefono;", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Combo_tipo_telefono.ValueMember = "idtipotelefono";
            Combo_tipo_telefono.DisplayMember = "Detalle";
            Combo_tipo_telefono.DataSource = dt;
        }

        public void llenarComboBox_tipo_correo(ComboBox Combo_tipo_correo)
        {
            MySqlConnection con = Adaptador.ObtenerConexion();
            MySqlCommand cm = new MySqlCommand("select * from tipocorreo;", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Combo_tipo_correo.ValueMember = "idtipocorreo";
            Combo_tipo_correo.DisplayMember = "detalle";

            Combo_tipo_correo.DataSource = dt;
        }

        //public void llenarComboBox_Nivel_Puesto(ComboBox Combo_Nivel_Puesto)
        //{
        //    MySqlConnection con = Adaptador.ObtenerConexion();
        //    MySqlCommand cm = new MySqlCommand("select * from tipocajero;", con);
        //    cm.CommandType = CommandType.Text;
        //    MySqlDataAdapter da = new MySqlDataAdapter(cm);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    Combo_Nivel_Puesto.ValueMember = "idtipocajero";
        //    Combo_Nivel_Puesto.DisplayMember = "rango";
        //    Combo_Nivel_Puesto.DataSource = dt;
        //}



        public void llenarComboBox_tipo_cliente(ComboBox Combo_tipo_cliente)
        {
            MySqlConnection con = Adaptador.ObtenerConexion();
            MySqlCommand cm = new MySqlCommand("select * from tipocliente;", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Combo_tipo_cliente.ValueMember = "idtipocliente";
            Combo_tipo_cliente.DisplayMember = "detalle";
            Combo_tipo_cliente.DataSource = dt;
        }






    }
}
