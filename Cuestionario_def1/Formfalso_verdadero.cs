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
    public partial class Formfalso_verdadero : Form
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
        

        public Formfalso_verdadero()
        {
            InitializeComponent();
        }

        private void Formfalso_verdadero_Load(object sender, EventArgs e)
        {
            label1_nombre_cuestionario.Text = snombre_cuestionario;
            label_pregunta.Text = spregunta;
            labelRespuesta1.Text = srespuesta1;
            labelRespuesta2.Text = srespuesta2;
            labelRespuesta3.Text = srespuesta3;
            labelRespuesta4.Text = srespuesta4;
        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sUsuario + id_pregunta1.ToString(), "usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Cuestionario pCuestionario = new Cuestionario();
            DateTime fechaActual = DateTime.Today;
            int resultado = 0;

            int suma = 0;
            if ((comboBox1FV.SelectedIndex.Equals(-1)) ||
                (comboBox2FV.SelectedIndex.Equals(-1)) ||
                (comboBox3FV.SelectedIndex.Equals(-1)) ||
                (comboBox4FV.SelectedIndex.Equals(-1)))
            {
                suma = 1;

                MessageBox.Show("Debe ingresar información en todas las cajas ya sea falso o verdadero");
            }

            if (suma == 0)
            {


                if (comboBox1FV.SelectedItem.ToString() == "Verdadero" && suma == 0)
                {
                    pCuestionario.activo = Convert.ToInt32(1);
                    pCuestionario.Usuario = sUsuario;
                    pCuestionario.Respuesta1 = srespuesta1;
                    pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                    pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                    pCuestionario.idCuestionario = idCuestionario;
                    resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
                }

                if (comboBox2FV.SelectedItem.ToString() == "Verdadero" && suma == 0)
                {
                    pCuestionario.activo = Convert.ToInt32(1);
                    pCuestionario.Usuario = sUsuario;
                    pCuestionario.Respuesta1 = srespuesta2;
                    pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                    pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                    pCuestionario.idCuestionario = idCuestionario;
                    resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
                }

                if (comboBox3FV.SelectedItem.ToString() == "Verdadero" && suma == 0)
                {
                    pCuestionario.activo = Convert.ToInt32(1);
                    pCuestionario.Usuario = sUsuario;
                    pCuestionario.Respuesta1 = srespuesta3;
                    pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                    pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                    pCuestionario.idCuestionario = idCuestionario;
                    resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
                }

                if (comboBox4FV.SelectedItem.ToString() == "Verdadero" && suma == 0)
                {
                    pCuestionario.activo = Convert.ToInt32(1);
                    pCuestionario.Usuario = sUsuario;
                    pCuestionario.Respuesta1 = srespuesta4;
                    pCuestionario.idPregunta = Convert.ToInt32(id_pregunta1);
                    pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                    pCuestionario.idCuestionario = idCuestionario;
                    resultado = Cuestionario_Contr.Agregar_Resultado_Encuesta(pCuestionario);
                }


                this.Close();
            }
        }
    }
}
