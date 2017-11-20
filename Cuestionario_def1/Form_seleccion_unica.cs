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
    public partial class Form_seleccion_unica : Form

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

        public Form_seleccion_unica()
        {
            InitializeComponent();
        }

        private void Form_seleccion_unica_Load(object sender, EventArgs e)
        {
            labelnombre_cuestionario.Text = snombre_cuestionario;
            labelPregunta.Text = spregunta;
            radioButton1.Text = srespuesta1;
            radioButton2.Text = srespuesta2;
            radioButton3.Text = srespuesta3;
            radioButton4.Text = srespuesta4;

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {


            DateTime fechaActual = DateTime.Today;
            int resultado = 0;
            if (radioButton1.Checked)
            {
                Cuestionario pCuestionario = new Cuestionario();
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta1 = srespuesta1;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            if (radioButton2.Checked)
            {
                Cuestionario pCuestionario = new Cuestionario();
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta1 = srespuesta2;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            if (radioButton3.Checked)
            {
                Cuestionario pCuestionario = new Cuestionario();
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Usuario = sUsuario;
                pCuestionario.Respuesta1 = srespuesta3;
                pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idCuestionario = idCuestionario;
                resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
            }

            if (radioButton4.Checked)
            {
                Cuestionario pCuestionario = new Cuestionario();
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
