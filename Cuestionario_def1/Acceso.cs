using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Cuestionario_def1
{
    public partial class Acceso : Form
    {

        MySqlCommand cmd = new MySqlCommand();
        public Acceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //cmd.Connection = Adaptador.ObtenerConexion();


            //try
            //{
            //    cmd.CommandText = "Select count(*) from Usuarios_sistema where Nombre_usuario = '" + textBoxusuario1.Text + "' and Contrasena = '" + textBoxcontrasena1.Text + "'";
            //    int valor = int.Parse(cmd.ExecuteScalar().ToString());



            //    //Comparamos si el valor 1 existe, si no no existe y no lo encontro en la BD

            //    if (valor == 1)
            //    {
            //        cmd.CommandText = "Select Tipo_usuario_idTipo_usuario from Usuarios_sistema where Nombre_usuario = '" + textBoxusuario1.Text + "' and Contrasena = '" + textBoxcontrasena1.Text + "'";
            //        int valor1 = int.Parse(cmd.ExecuteScalar().ToString());

           
                    

            //        if (valor1==1)
            //        {
            //            menu_cliente frm1 = new menu_cliente();
            //            frm1.Show();
            //        }
            //        if (valor1==2)
            //        {
                        menu_administrador frm = new menu_administrador();
                        frm.Show();
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario o contraseña inválidos, intentelo de nuevo");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("ERROR: "+ex);
            //}
            //Adaptador.CerrarConexion();
            

        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }
    }
}
