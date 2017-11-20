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
    public partial class menu_cliente : Form
    {
        public string sUsuario;

        public menu_cliente()
        {
            InitializeComponent();
        }

        private void button1_Buscarcuestionario_Click(object sender, EventArgs e)
        {
            Responder_cuestionario frm1 = new Responder_cuestionario();
            frm1.ShowDialog();

            List<Cuestionario> Cuestionarioseleccionado1 = frm1.Cuestionarioseleccionado;

            dataGridView1.DataSource = Cuestionarioseleccionado1;

            if (Cuestionarioseleccionado1 != null)
            {

                DateTime fechaActual = DateTime.Today;
                int resultado = 0;
                Cuestionario pCuestionario = new Cuestionario();
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = Convert.ToInt32(Cuestionarioseleccionado1[0].idCuestionario);
                resultado = Cuestionario_Contr.Agregar_Cuestionario_usuario(pCuestionario);

                for (int i = 0; i < frm1.Cuestionarioseleccionado.Count; i = i + 4)
                {
                    MessageBox.Show(sUsuario, "usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                    if (Cuestionarioseleccionado1[i].idtipo_pregunta == 1)
                    {
                        Form_seleccion_unica frmsu = new Form_seleccion_unica();
                        frmsu.snombre_cuestionario = Cuestionarioseleccionado1[i].Nombre_cuestionario.ToString();
                        frmsu.spregunta = Cuestionarioseleccionado1[i].Pregunta.ToString();
                        frmsu.id_pregunta1 = Convert.ToInt32(Cuestionarioseleccionado1[i].idPregunta);
                        frmsu.srespuesta1 = Cuestionarioseleccionado1[i].Respuesta1.ToString();
                        frmsu.srespuesta2 = Cuestionarioseleccionado1[i + 1].Respuesta1.ToString();
                        frmsu.srespuesta3 = Cuestionarioseleccionado1[i + 2].Respuesta1.ToString();
                        frmsu.srespuesta4 = Cuestionarioseleccionado1[i + 3].Respuesta1.ToString();
                        frmsu.sUsuario = sUsuario.ToString();
                        frmsu.idCuestionario = Convert.ToInt32(Cuestionarioseleccionado1[i].idCuestionario);
                        frmsu.ShowDialog();

                    }
                    if (Cuestionarioseleccionado1[i].idtipo_pregunta == 2)
                    {
                        Formfalso_verdadero frmfv = new Formfalso_verdadero();
                        frmfv.snombre_cuestionario = Cuestionarioseleccionado1[i].Nombre_cuestionario.ToString();
                        frmfv.spregunta = Cuestionarioseleccionado1[i].Pregunta.ToString();
                        frmfv.id_pregunta1 = Convert.ToInt32(Cuestionarioseleccionado1[i].idPregunta);
                        frmfv.srespuesta1 = Cuestionarioseleccionado1[i].Respuesta1.ToString();
                        frmfv.srespuesta2 = Cuestionarioseleccionado1[i + 1].Respuesta1.ToString();
                        frmfv.srespuesta3 = Cuestionarioseleccionado1[i + 2].Respuesta1.ToString();
                        frmfv.srespuesta4 = Cuestionarioseleccionado1[i + 3].Respuesta1.ToString();
                        frmfv.sUsuario = sUsuario.ToString();
                        frmfv.idCuestionario = Convert.ToInt32(Cuestionarioseleccionado1[i].idCuestionario);
                        frmfv.ShowDialog();
                    }
                    if (Cuestionarioseleccionado1[i].idtipo_pregunta == 3)
                    {
                        FormSeleccion_multiple frmsm = new FormSeleccion_multiple();
                        frmsm.snombre_cuestionario = Cuestionarioseleccionado1[i].Nombre_cuestionario.ToString();
                        frmsm.spregunta = Cuestionarioseleccionado1[i].Pregunta.ToString();
                        frmsm.id_pregunta1 = Convert.ToInt32(Cuestionarioseleccionado1[i].idPregunta);
                        frmsm.srespuesta1 = Cuestionarioseleccionado1[i].Respuesta1.ToString();
                        frmsm.srespuesta2 = Cuestionarioseleccionado1[i + 1].Respuesta1.ToString();
                        frmsm.srespuesta3 = Cuestionarioseleccionado1[i + 2].Respuesta1.ToString();
                        frmsm.srespuesta4 = Cuestionarioseleccionado1[i + 3].Respuesta1.ToString();
                        frmsm.sUsuario = sUsuario.ToString();
                        frmsm.idCuestionario = Convert.ToInt32(Cuestionarioseleccionado1[i].idCuestionario);
                        frmsm.ShowDialog();
                    }

                }

                MessageBox.Show("Ha completado la Encuesta", "Encuesta finalizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menu_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
