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
    public partial class Responder_cuestionario : Form
    {
        public List<Cuestionario> Cuestionarioseleccionado = new List<Cuestionario>();

        public Responder_cuestionario()
        {
            InitializeComponent();
        }

        private void button2buscarcuestionario_Click(object sender, EventArgs e)
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

        }
    }
}
