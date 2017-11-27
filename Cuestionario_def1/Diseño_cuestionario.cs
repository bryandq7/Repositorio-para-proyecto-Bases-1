﻿using System;
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
    public partial class Diseño_cuestionario : Form
    {
        public string sUsuario;
        Adaptador cbx = new Adaptador();

        public Diseño_cuestionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Diseño_cuestionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if(textBoxNombre_cuestionario.Text=="" || textBox_cant_preguntas.Text == "")
            {
                MessageBox.Show("Ingrese datos en las cajas de texto");
                contador = 1;
            }

            if (contador==0)
            {

            Cuestionario pCuestionario = new Cuestionario();
            DateTime fechaActual = DateTime.Today;

            Diseño_de_pregunta frm1 = new Diseño_de_pregunta();
            
            frm1.sNombre_cuestionario = textBoxNombre_cuestionario.Text.Trim();
            frm1.scantidad_preguntas = Convert.ToInt32(textBox_cant_preguntas.Text.Trim());
            frm1.sfechacreacion = fechaActual.Year + "/" + fechaActual.Month + "/" + fechaActual.Day;
            frm1.sUsuario = sUsuario;
            MessageBox.Show(sUsuario, "usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm1.ShowDialog( );

            this.Close();

            }

        }

        private void textBoxNombre_cuestionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBox_cant_preguntas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox_cant_preguntas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
