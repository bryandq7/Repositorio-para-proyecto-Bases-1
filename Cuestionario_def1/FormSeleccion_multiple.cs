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
    public partial class FormSeleccion_multiple : Form
    {
        public string snombre_cuestionario;
        public string spregunta;
        public string srespuesta1;
        public string srespuesta2;
        public string srespuesta3;
        public string srespuesta4;
        public int id_pregunta1;
        public string sUsuario;
        public int idCuestionario;

        public FormSeleccion_multiple()
        {
            InitializeComponent();
        }

        private void FormSeleccion_multiple_Load(object sender, EventArgs e)
        {
            label1_nombre_cuestionario.Text = snombre_cuestionario;
            label_pregunta.Text = spregunta;
            checkBox1.Text = srespuesta1;
            checkBox2.Text = srespuesta2;
            checkBox3.Text = srespuesta3;
            checkBox4.Text = srespuesta4;
        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            Cuestionario pCuestionario = new Cuestionario();
            DateTime fechaActual = DateTime.Today;
            int resultado = 0;
            if (checkBox1.Checked)
            {
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta1 = srespuesta1;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            if (checkBox2.Checked)
            {
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta1 = srespuesta2;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            if (checkBox3.Checked)
            {
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta1 = srespuesta3;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            if (checkBox4.Checked)
            {
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta4 = srespuesta4;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            this.Close();
        }
    }
}
