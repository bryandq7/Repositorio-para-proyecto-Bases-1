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
        public Cuestionario Cuestionarioseleccionado { get; set; }

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
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
            this.dataGridView1.Columns[15].Visible = false;
            this.dataGridView1.Columns[17].Visible = false;
        }
    }
}
