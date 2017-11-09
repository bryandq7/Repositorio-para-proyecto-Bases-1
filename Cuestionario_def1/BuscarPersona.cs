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
    public partial class BuscarPersona : Form
    {
        public BuscarPersona()
        {
            InitializeComponent();
        }

        public Cliente Clienteseleccionado { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Clientes_Contr.Buscar(textBoxbuscarnombre.Text, textBoxbuscarapellido1.Text);

        }

        private void buttonaceptarseleccionado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int cedula = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Clienteseleccionado = Clientes_Contr.ObtenerCliente(cedula);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
    }
}
