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
        public int contador_preguntas;
        public string sUsuario;
        int num_cuestionario = 0;


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
            labeltipo_pregunta.Text = comboBoxtipo_pregunta.SelectedText.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mtipo_pregunta = Convert.ToInt32(comboBoxtipo_pregunta.SelectedValue);
            int mestado1 = Convert.ToInt32(comboBox2.SelectedIndex.ToString());
            int mestado2 = Convert.ToInt32(comboBox3.SelectedIndex.ToString());
            int mestado3 = Convert.ToInt32(comboBox4.SelectedIndex.ToString());
            int mestado4 = Convert.ToInt32(comboBox5.SelectedIndex.ToString());

            int resultado=0;

            num_cuestionario = num_cuestionario+1;
            int cant_correcto =0;

            if(mestado1 == 0)
            {cant_correcto = cant_correcto + 1;}
            if (mestado2 == 0)
            {cant_correcto = cant_correcto + 1;}
            if (mestado3 == 0)
            {cant_correcto = cant_correcto + 1;}
            if (mestado4 == 0)
            {cant_correcto = cant_correcto + 1;}

            MessageBox.Show(mtipo_pregunta.ToString(), "tipo pregunta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show(sUsuario, "usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {

  

            if (mtipo_pregunta == 1 && cant_correcto ==1)
            {
                contador_preguntas = contador_preguntas + 1;

                Cuestionario pCuestionario = new Cuestionario();
                DateTime fechaActual = DateTime.Today;

                pCuestionario.Nombre_cuestionario = sNombre_cuestionario;
                pCuestionario.cantidad_preguntas = scantidad_preguntas;
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idtipo_pregunta = Convert.ToInt32(comboBoxtipo_pregunta.SelectedValue);
                pCuestionario.Pregunta = textBoxPregunta.Text.Trim();
                pCuestionario.Respuesta1 = textBoxrespuesta1.Text.Trim();
                pCuestionario.Respuesta2 = textBoxrespuesta2.Text.Trim();
                pCuestionario.Respuesta3 = textBoxrespuesta3.Text.Trim();
                pCuestionario.Respuesta4 = textBoxrespuesta4.Text.Trim();
                pCuestionario.Estado1 = comboBox2.SelectedItem.ToString();
                pCuestionario.Estado2 = comboBox3.SelectedItem.ToString();
                pCuestionario.Estado3 = comboBox4.SelectedItem.ToString();
                pCuestionario.Estado4 = comboBox5.SelectedItem.ToString();
                pCuestionario.Usuario = sUsuario;


                 resultado = Cuestionario_Contr.Agregar(pCuestionario, num_cuestionario);

            }

            if (mtipo_pregunta == 2 && cant_correcto >= 1)
            {

                contador_preguntas = contador_preguntas + 1;

                Cuestionario pCuestionario = new Cuestionario();
                DateTime fechaActual = DateTime.Today;

                pCuestionario.Nombre_cuestionario = sNombre_cuestionario;
                pCuestionario.cantidad_preguntas = scantidad_preguntas;
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idtipo_pregunta = Convert.ToInt32(comboBoxtipo_pregunta.SelectedValue);
                pCuestionario.Pregunta = textBoxPregunta.Text.Trim();
                pCuestionario.Respuesta1 = textBoxrespuesta1.Text.Trim();
                pCuestionario.Respuesta2 = textBoxrespuesta2.Text.Trim();
                pCuestionario.Respuesta3 = textBoxrespuesta3.Text.Trim();
                pCuestionario.Respuesta4 = textBoxrespuesta4.Text.Trim();
                pCuestionario.Estado1 = comboBox2.SelectedItem.ToString();
                pCuestionario.Estado2 = comboBox3.SelectedItem.ToString();
                pCuestionario.Estado3 = comboBox4.SelectedItem.ToString();
                pCuestionario.Estado4 = comboBox5.SelectedItem.ToString();
                    pCuestionario.Usuario = sUsuario;


                    resultado = Cuestionario_Contr.Agregar(pCuestionario, num_cuestionario);

            }

            if (mtipo_pregunta == 3 && cant_correcto > 1)
            {
                contador_preguntas = contador_preguntas + 1;

                Cuestionario pCuestionario = new Cuestionario();
                DateTime fechaActual = DateTime.Today;

                pCuestionario.Nombre_cuestionario = sNombre_cuestionario;
                pCuestionario.cantidad_preguntas = scantidad_preguntas;
                pCuestionario.activo = Convert.ToInt32(1);
                pCuestionario.Fecha_creacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
                pCuestionario.idtipo_pregunta = Convert.ToInt32(comboBoxtipo_pregunta.SelectedValue);
                pCuestionario.Pregunta = textBoxPregunta.Text.Trim();
                pCuestionario.Respuesta1 = textBoxrespuesta1.Text.Trim();
                pCuestionario.Respuesta2 = textBoxrespuesta2.Text.Trim();
                pCuestionario.Respuesta3 = textBoxrespuesta3.Text.Trim();
                pCuestionario.Respuesta4 = textBoxrespuesta4.Text.Trim();
                pCuestionario.Estado1 = comboBox2.SelectedItem.ToString();
                pCuestionario.Estado2 = comboBox3.SelectedItem.ToString();
                pCuestionario.Estado3 = comboBox4.SelectedItem.ToString();
                pCuestionario.Estado4 = comboBox5.SelectedItem.ToString();
                    pCuestionario.Usuario = sUsuario;


                    resultado = Cuestionario_Contr.Agregar(pCuestionario, num_cuestionario);
            }

                if (mtipo_pregunta == 1 && cant_correcto > 1)
                {

                    MessageBox.Show("Escogió mas de una Opción correcta cuando eligió Tipo de Pregunta " +
                        " de selección única", "Revise su Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (mtipo_pregunta == 3 && cant_correcto == 1)
                {
                    MessageBox.Show("Escogió SOLO una Opción correcta cuando eligió Tipo de Pregunta " +
                        " de selección multiple", "Revise su Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (cant_correcto == 0)
                {
                    MessageBox.Show("Debe escoger al menos una respuesta correcta", "Revise su Pregunta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                throw;
            }



                if (resultado > 0)
            {
                MessageBox.Show("Cuestionario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show("No se pudo guardar el Cuestionario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (contador_preguntas<scantidad_preguntas && resultado > 0)
            {

                textBoxPregunta.Clear();
                textBoxrespuesta1.Clear();
                textBoxrespuesta2.Clear();
                textBoxrespuesta3.Clear();
                textBoxrespuesta4.Clear();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                label8_numero_de_pregunta.Text = Convert.ToString(contador_preguntas + 1 + "/" + scantidad_preguntas);

                //Diseño_de_pregunta frm1 = new Diseño_de_pregunta();
                //frm1.sNombre_cuestionario = sNombre_cuestionario;
                //frm1.scantidad_preguntas = scantidad_preguntas;
                //frm1.sfechacreacion = sfechacreacion;
                //frm1.contador_preguntas = contador_preguntas;
                //frm1.ShowDialog();
                //this.Hide();
            }
            if (contador_preguntas == scantidad_preguntas && resultado > 0)
            {
                MessageBox.Show("Ha Terminado de ingresar su Cuestionario", "Felicidades!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
            }

            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
