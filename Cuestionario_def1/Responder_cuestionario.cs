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
    public partial class Responder_cuestionario : Form
    {
        public List<Cuestionario> Cuestionarioseleccionado = new List<Cuestionario>();
        public string usuario;
        MySqlCommand cmd = new MySqlCommand();
        public int valor1;

        public Responder_cuestionario()
        {
            InitializeComponent();

        }

        private void button2buscarcuestionario_Click(object sender, EventArgs e)
        {
            cmd.Connection = Adaptador.ObtenerConexion();
            cmd.CommandText = "Select Tipo_usuario_idTipo_usuario from Usuarios_sistema where Nombre_usuario = '" + usuario + "'";
            valor1 = int.Parse(cmd.ExecuteScalar().ToString());




            //Comparamos si el valor 1 existe, si no no existe y no lo encontro en la BD


            int campo_nombre1 = 0;


            if (textBoxbuscarnombre.Text == "")
            {
                campo_nombre1 = 1;
                MessageBox.Show("No colocó ningun nombre, intentelo de nuevo");
            }

            if (valor1 == 1 && campo_nombre1==0)
                {
                dataGridView1.DataSource = Cuestionario_Contr.Buscar(textBoxbuscarnombre.Text, textBoxbuscarapellido1.Text);
                this.dataGridView1.Columns[1].Visible = false;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;
                this.dataGridView1.Columns[8].Visible = false;
                this.dataGridView1.Columns[9].Visible = false;
                this.dataGridView1.Columns[10].Visible = false;
                this.dataGridView1.Columns[11].Visible = false;
                this.dataGridView1.Columns[13].Visible = false;
                this.dataGridView1.Columns[17].Visible = false;
                this.dataGridView1.Columns[18].Visible = false;
            }

            try
            {

                int campo_nombre = 0;


                if (textBoxbuscarnombre.Text=="")
                {
                    campo_nombre = 1;
                    MessageBox.Show("No colocó ningun nombre, intentelo de nuevo");
                }

                if (valor1 == 2 && campo_nombre == 0)
                {
                    if (radioButtoncuestionarios.Checked)
                    {
                        dataGridView1.DataSource = Cuestionario_Contr.reporteCuestionario(textBoxbuscarnombre.Text);
                        this.dataGridView1.Columns[0].Visible = true;
                        this.dataGridView1.Columns[1].Visible = false;
                        this.dataGridView1.Columns[2].Visible = false;
                        this.dataGridView1.Columns[3].Visible = false;
                        this.dataGridView1.Columns[4].Visible = false;
                        this.dataGridView1.Columns[5].Visible = true;
                        this.dataGridView1.Columns[6].Visible = false;
                        this.dataGridView1.Columns[7].Visible = false;
                        this.dataGridView1.Columns[8].Visible = false;
                        this.dataGridView1.Columns[9].Visible = false;
                        this.dataGridView1.Columns[10].Visible = false;
                        this.dataGridView1.Columns[11].Visible = false;
                        this.dataGridView1.Columns[12].Visible = true;
                        this.dataGridView1.Columns[13].Visible = false;
                        this.dataGridView1.Columns[14].Visible = false;
                        this.dataGridView1.Columns[15].Visible = false;
                        this.dataGridView1.Columns[16].Visible = false;
                        this.dataGridView1.Columns[17].Visible = false;
                        this.dataGridView1.Columns[18].Visible = false;

                        dataGridView1.Columns[0].HeaderText = "Nombre de Cuestionario";
                        dataGridView1.Columns[5].HeaderText = "Personas que han respondido este cuestionario";
                        dataGridView1.Columns[12].HeaderText = "Número de cuestionario";




                        dataGridView1.Columns[0].DisplayIndex = 1;
                        dataGridView1.Columns[5].DisplayIndex = 2;
                        dataGridView1.Columns[12].DisplayIndex = 0;


                    }

                if (radioButtonrespuestas.Checked)
                {
                    dataGridView1.DataSource = Cuestionario_Contr.reporteRespuestas(textBoxbuscarnombre.Text);
                        this.dataGridView1.Columns[0].Visible = true;
                        this.dataGridView1.Columns[1].Visible = false;
                        this.dataGridView1.Columns[2].Visible = false;
                        this.dataGridView1.Columns[3].Visible = false;
                        this.dataGridView1.Columns[4].Visible = true;
                        this.dataGridView1.Columns[5].Visible = true;
                        this.dataGridView1.Columns[6].Visible = false;
                        this.dataGridView1.Columns[7].Visible = false;
                        this.dataGridView1.Columns[8].Visible = true;
                        this.dataGridView1.Columns[9].Visible = false;
                        this.dataGridView1.Columns[10].Visible = false;
                        this.dataGridView1.Columns[11].Visible = false;
                        this.dataGridView1.Columns[12].Visible = false;
                        this.dataGridView1.Columns[13].Visible = false;
                        this.dataGridView1.Columns[14].Visible = false;
                        this.dataGridView1.Columns[15].Visible = false;
                        this.dataGridView1.Columns[16].Visible = false;
                        this.dataGridView1.Columns[17].Visible = false;
                        this.dataGridView1.Columns[18].Visible = false;

                        dataGridView1.Columns[0].HeaderText = "Nombre de Cuestionario";
                        dataGridView1.Columns[4].HeaderText = "Pregunta";
                        dataGridView1.Columns[5].HeaderText = "Personas que respondieron esta respuesta";
                        dataGridView1.Columns[8].HeaderText = "Respuesta";




                        dataGridView1.Columns[0].DisplayIndex = 0;
                        dataGridView1.Columns[4].DisplayIndex = 1;
                        dataGridView1.Columns[5].DisplayIndex = 3;
                        dataGridView1.Columns[8].DisplayIndex = 2;
                      
                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No colocó ningun nombre, intentelo de nuevo");

                throw;
            }


        }

        private void buttonaceptarseleccionado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id_cuestionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                Cuestionarioseleccionado = Cuestionario_Contr.ObtenerCuestionario(id_cuestionario);

                //for (int i = 0; i < Cuestionarioseleccionado.Count; i++)
                //{
                //    if (Cuestionarioseleccionado != null)
                //    {
                //        if (Cuestionarioseleccionado.idtipo_pregunta == 1)
                //        {
                //            Form_seleccion_unica frmsu = new Form_seleccion_unica();
                //            frmsu.ShowDialog();

                //        }
                //        if (Cuestionarioseleccionado.idtipo_pregunta == 2)
                //        {

                //        }
                //        if (Cuestionarioseleccionado.idtipo_pregunta == 3)
                //        {

                //        }
                //    }
                    this.Close();
                }
            else
                MessageBox.Show("debe de seleccionar una fila");
            }

        private void Responder_cuestionario_Load(object sender, EventArgs e)
        {

            cmd.Connection = Adaptador.ObtenerConexion();
            cmd.CommandText = "Select Tipo_usuario_idTipo_usuario from Usuarios_sistema where Nombre_usuario = '" + usuario + "'";
            valor1 = int.Parse(cmd.ExecuteScalar().ToString());

            if (valor1 == 2)
            {
                buttonaceptarseleccionado.Enabled = false;
                textBoxbuscarapellido1.Enabled = false;


            }


            if (valor1 == 1)
            {
                radioButtonrespuestas.Enabled=false;
                radioButtoncuestionarios.Enabled = false;


            }

        }

        private void buttoncancelarseleccionado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
