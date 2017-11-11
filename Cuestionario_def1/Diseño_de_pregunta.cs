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
    public partial class Diseño_de_pregunta : Form
    {
        public string sNombre_cuestionario;
        public int scantidad_preguntas;
        public string sfechacreacion;
        public int sid_tipo_pregunta;
        public int contador_preguntas;
        

        Adaptador cbx = new Adaptador();


        public Diseño_de_pregunta()
        {
            InitializeComponent();
        }

        //public Diseño_de_pregunta(string dNombre_cuestionario, int dcantidad_preguntas,
        //    int dactivo, string dFecha_creacion, int did_tipo_pregunta)
        //{
        //    InitializeComponent();

        //    string sNombre_cuestionario = dNombre_cuestionario;
        //    int scantidad_preguntas = dcantidad_preguntas;
        //    string sfechacreacion = dFecha_creacion;
        //    int sid_tipo_pregunta = did_tipo_pregunta;
        //}

        private void Diseño_de_pregunta_Load(object sender, EventArgs e)
        {
            cbx.llenarComboBox_tipo_pregunta(comboBoxtipo_pregunta);

            label8_numero_de_pregunta.Text = Convert.ToString(contador_preguntas+1+"/"+scantidad_preguntas);
            labelNombre_cuestionario.Text = sNombre_cuestionario;
            labeltipo_pregunta.Text = Convert.ToString(sid_tipo_pregunta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador_preguntas = contador_preguntas + 1;

            Cuestionario pCuestionario = new Cuestionario();
            DateTime fechaActual = DateTime.Today;

            pCuestionario.Nombre_cuestionario = sNombre_cuestionario;
            pCuestionario.cantidad_preguntas = scantidad_preguntas;
            pCuestionario.activo = Convert.ToInt32(1);
            pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
            pCuestionario.idtipo_pregunta = Convert.ToInt32(sid_tipo_pregunta);
            pCuestionario.Pregunta = textBoxPregunta.Text.Trim();
            pCuestionario.Respuesta1 = textBoxrespuesta1.Text.Trim();
            pCuestionario.Respuesta2 = textBoxrespuesta2.Text.Trim();
            pCuestionario.Respuesta3 = textBoxrespuesta3.Text.Trim();
            pCuestionario.Respuesta4 = textBoxrespuesta4.Text.Trim();
            pCuestionario.Estado1 = comboBox2.SelectedItem.ToString();
            pCuestionario.Estado2 = comboBox3.SelectedItem.ToString();
            pCuestionario.Estado3 = comboBox4.SelectedItem.ToString();
            pCuestionario.Estado4 = comboBox5.SelectedItem.ToString();


        int resultado = Cuestionario_Contr.Agregar(pCuestionario);

            if (resultado > 0)
            {
                MessageBox.Show("Cuestionario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show("No se pudo guardar el Cuestionario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (contador_preguntas<scantidad_preguntas)
            {
                Diseño_de_pregunta frm1 = new Diseño_de_pregunta();
                frm1.sNombre_cuestionario = sNombre_cuestionario;
                frm1.scantidad_preguntas = scantidad_preguntas;
                frm1.sid_tipo_pregunta = sid_tipo_pregunta;
                frm1.sfechacreacion = sfechacreacion;
                frm1.contador_preguntas = contador_preguntas;
                //frm1.comboBoxtipo_pregunta = Convert.ToInt32(comboBoxtipo_pregunta.SelectedValue);
                frm1.ShowDialog();
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
